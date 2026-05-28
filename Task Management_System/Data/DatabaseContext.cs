using System;
using System.IO;
using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;

namespace Task_Management_System.Data
{
    public static class DatabaseContext
    {
        private static readonly string DbFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        private static readonly string DbPath = Path.Combine(DbFolder, "DB_TaskManagement.db");

        // Fast shared connection string with WAL mode built-in directly to handle multi-tab queries smoothly
        public static readonly string ConnectionString = $"Data Source={DbPath};Journal Mode=Wal;Synchronous=Normal;Cache=Shared;";

        /// <summary>
        /// Instantiates a clean, opened, thread-safe connection to the SQLite database.
        /// </summary>
        public static IDbConnection CreateConnection()
        {
            if (!Directory.Exists(DbFolder))
            {
                Directory.CreateDirectory(DbFolder);
            }

            var connection = new SqliteConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Validates structural integrity and creates tables for user controls if missing.
        /// </summary>
        public static void InitializeDatabaseSchema()
        {
            using (var connection = CreateConnection())
            {
                // 1. Appointments Table (Powers DevExpress Scheduler)
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

                // 2. StudentProfile Table (Powers Profile Dashboard Views)
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

                // 3. Dashboard Announcements Table (Powers Home overview stream)
                connection.Execute(@"
                    CREATE TABLE IF NOT EXISTS DashboardAnnouncements (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        Content TEXT,
                        DatePosted TEXT,
                        Priority INTEGER DEFAULT 0
                    );");

                // Seeding Default Profiles if empty
                if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM StudentProfile;") == 0)
                {
                    connection.Execute(@"
                        INSERT INTO StudentProfile (StudentId, FullName, Email, Course, Phone, PasswordHash)
                        VALUES ('STU-2026-0001', 'Administrator', 'admin@university.edu', 'B.S. Computer Science', '+1 (555) 019-2834', '123');");
                }

                // Seeding Default Announcements if empty
                if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM DashboardAnnouncements;") == 0)
                {
                    connection.Execute(@"
                        INSERT INTO DashboardAnnouncements (Title, Content, DatePosted, Priority)
                        VALUES ('Welcome to your Student Workspace!', 'Use the sidebar navigation tabs to monitor assignments, adjust your profile, or manage schedules.', '2026-05-28', 1);");
                }
            }
        }
    }
}