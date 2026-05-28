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

        // 🎯 FIXED: Optimized connection flags to support stable connection pooling across multiple worker threads
        public static readonly string ConnectionString = $"Data Source={DbPath};Cache=Shared;Pooling=True;";

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

            // ⚡ PERFORMANCE INJECTION: Execute WAL engine optimizations cleanly via PRAGMA commands to avoid cross-tab lockouts
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "PRAGMA journal_mode=WAL; PRAGMA synchronous=NORMAL;";
                command.ExecuteNonQuery();
            }

            // Automatically structuralize database layout setup trace
            InitializeDatabaseSchemaInternal(connection);

            return connection;
        }

        /// <summary>
        /// Public-facing wrapper to explicitly enforce database validation on startup if needed.
        /// </summary>
        public static void InitializeDatabaseSchema()
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                InitializeDatabaseSchemaInternal(connection);
            }
        }

        /// <summary>
        /// Validates structural integrity and creates tables for user controls if missing.
        /// </summary>
        private static void InitializeDatabaseSchemaInternal(SqliteConnection connection)
        {
            // 1. Users Table (🎯 FIXED: Removed illegal trailing syntax characters)
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL
                );");

            // 2. Students Table
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS Students (
                    StudentId TEXT PRIMARY KEY,
                    FullName TEXT,
                    Email TEXT,
                    Course TEXT,
                    Phone TEXT,
                    PasswordHash TEXT,
                    ProfileImage BLOB
                );");

            // 3. StudentTask Table
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS StudentTask (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID TEXT,
                    FirstName TEXT,
                    LastName TEXT,
                    Section TEXT,
                    Date TEXT,
                    Photo TEXT,
                    FOREIGN KEY (StudentID) REFERENCES Students(StudentId) ON DELETE CASCADE
                );");

            // 4. Appointments Table (Powers DevExpress Scheduler)
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

            // 5. Dashboard Announcements Table (Powers Home overview stream)
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS DashboardAnnouncements (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Content TEXT,
                    DatePosted TEXT,
                    Priority INTEGER DEFAULT 0
                );");

            // 6. Admin Table (🎯 FIXED: Injected missing table required by your schema specification)
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS Admin (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    picture BLOB,
                    Student_Id TEXT,
                    FirstName TEXT,
                    LastName TEXT,
                    Section TEXT,
                    Date TEXT
                );");

            // 🔄 BACKWARD COMPATIBILITY SCHEMA MIGRATIONS
            try
            {
                if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM sqlite_master WHERE type='table' AND name='StudentProfile';") > 0)
                {
                    connection.Execute(@"
                        INSERT OR IGNORE INTO Students (StudentId, FullName, Email, Course, Phone, PasswordHash)
                        SELECT StudentId, FullName, Email, Course, Phone, PasswordHash FROM StudentProfile;");
                }
            }
            catch (SqliteException) { /* Handled safely */ }

            try
            {
                if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM sqlite_master WHERE type='table' AND name='User';") > 0)
                {
                    connection.Execute(@"
                        INSERT OR IGNORE INTO Users (Username, Password)
                        SELECT Username, Password FROM User;");
                }
            }
            catch (SqliteException) { /* Handled safely */ }


            // 📦 SEED DEFAULT RECORDS FOR TESTING LOGINS
            // Seeds 'STU-2026-0001' account
            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Students WHERE StudentId = 'STU-2026-0001';") == 0)
            {
                connection.Execute(@"
                    INSERT INTO Students (StudentId, FullName, Email, Course, Phone, PasswordHash, ProfileImage)
                    VALUES ('STU-2026-0001', 'Administrator', 'admin@university.edu', 'B.S. Computer Science', '+1 (555) 019-2834', '123', NULL);");
            }
            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Users WHERE Username = 'STU-2026-0001';") == 0)
            {
                connection.Execute(@"
                    INSERT INTO Users (Username, Password)
                    VALUES ('STU-2026-0001', '123');");
            }

            // Seeds '2016-0474' account
            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Students WHERE StudentId = '2016-0474';") == 0)
            {
                connection.Execute(@"
                    INSERT INTO Students (StudentId, FullName, Email, Course, Phone, PasswordHash, ProfileImage)
                    VALUES ('2016-0474', 'Khimuel Diamante', 'khimueld_diamante@dmc.edu.ph', 'IT', '093524656', 'KhimzUgh', NULL);");
            }
            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Users WHERE Username = '2016-0474';") == 0)
            {
                connection.Execute(@"
                    INSERT INTO Users (Username, Password)
                    VALUES ('2016-0474', 'KhimzUgh');");
            }

            // Ensure 'admin' user profile structure exists inside BOTH tables explicitly to prevent sync failures
            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Users WHERE Username = 'admin';") == 0)
            {
                connection.Execute("INSERT INTO Users (Username, Password) VALUES ('admin', '123');");
            }
            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Students WHERE StudentId = 'admin';") == 0)
            {
                connection.Execute(@"
                    INSERT INTO Students (StudentId, FullName, Email, Course, Phone, PasswordHash, ProfileImage)
                    VALUES ('admin', 'System Administrator', 'admin@dmc.edu.ph', 'IT Management', '00000', '123', NULL);");
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