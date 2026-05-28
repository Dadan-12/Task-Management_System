using System;
using System.IO;
using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;

namespace Task_Management_System.Data
{
    public static class DatabaseContext
    {
        private static readonly string DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TaskManagement.db");
        public static readonly string ConnectionString = $"Data Source={DbPath};";

        /// <summary>
        /// Instantiates a thread-safe connection to the SQLite database.
        /// </summary>
        public static IDbConnection CreateConnection() => new SqliteConnection(ConnectionString);

        /// <summary>
        /// Validates structural integrity and creates tables asynchronously if missing.
        /// </summary>
        public static void InitializeDatabaseSchema()
        {
            using (var connection = CreateConnection())
            {
                connection.Open();

                // 1. Appointments Table
                connection.Execute(@"
                    CREATE TABLE IF NOT EXISTS Appointments (
                        UniqueId TEXT PRIMARY KEY,
                        Subject TEXT,
                        Description TEXT,
                        StartTime TEXT,
                        EndTime TEXT,
                        LabelKey INTEGER,
                        StatusKey INTEGER,
                        AllDay INTEGER,
                        Location TEXT,
                        ReminderInfo TEXT
                    );");

                // 2. Profile Management Table
                connection.Execute(@"
                    CREATE TABLE IF NOT EXISTS StudentProfile (
                        StudentId TEXT PRIMARY KEY,
                        FullName TEXT,
                        Email TEXT,
                        Course TEXT,
                        Phone TEXT,
                        PasswordHash TEXT,
                        ProfileImageBlob BLOB
                    );");

                // Seed initial data if the workspace profile state is completely empty
                int existingProfiles = connection.ExecuteScalar<int>("SELECT COUNT(1) FROM StudentProfile;");
                if (existingProfiles == 0)
                {
                    connection.Execute(@"
                        INSERT INTO StudentProfile (StudentId, FullName, Email, Course, Phone, PasswordHash)
                        VALUES ('STU-2026-0001', 'John Doe', 'student@university.edu', 'B.S. Computer Science', '+1 (555) 019-2834', 'Password123');");
                }
            }
        }
    }

    /// <summary>
    /// Represents standard DevExpress Appointment attributes mapped natively into the SQLite data platform via Dapper.
    /// </summary>
    public class DbAppointment
    {
        public string UniqueId { get; set; } = Guid.NewGuid().ToString();
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int LabelKey { get; set; }
        public int StatusKey { get; set; }
        public bool AllDay { get; set; }
        public string Location { get; set; }
        public string ReminderInfo { get; set; }
    }

    /// <summary>
    /// POCO layout reflecting student security profile properties.
    /// </summary>
    public class DbStudentProfile
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public byte[] ProfileImageBlob { get; set; }
    }
}