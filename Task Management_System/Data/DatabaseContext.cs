using System;
using System.IO;
using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;

namespace Task_Management_System.Data
{
    /// <summary>
    /// Provides global database configuration, connection pooling optimization, and automatic schema initialization.
    /// </summary>
    public static class DatabaseContext
    {
        private static readonly string DbFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        private static readonly string DbPath = Path.Combine(DbFolder, "DB_TaskManagement.db");

        public static readonly string ConnectionString = $"Data Source={DbPath};Cache=Shared;Pooling=True;";

        /// <summary>
        /// Instantiates a thread-safe connection instance pointing to the designated SQLite database.
        /// </summary>
        public static IDbConnection CreateConnection()
        {
            if (!Directory.Exists(DbFolder))
            {
                Directory.CreateDirectory(DbFolder);
            }

            var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            // Execute Write-Ahead Logging (WAL) and performance optimizations
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "PRAGMA journal_mode=WAL; PRAGMA synchronous=NORMAL;";
                command.ExecuteNonQuery();
            }

            InitializeDatabaseSchemaInternal(connection);

            return connection;
        }

        /// <summary>
        /// Public validation wrapper to explicitly enforce database validation on application startup.
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
        /// Validates database structural integrity and builds out schemas if missing.
        /// </summary>
        private static void InitializeDatabaseSchemaInternal(IDbConnection connection)
        {
            // Table 1: Security Logins Registry
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL
                );");

            // Table 2: Student Basic Demographics Registry
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS Students (
                    StudentId TEXT PRIMARY KEY,
                    FullName TEXT,
                    Email TEXT,
                    Course TEXT,
                    Section TEXT,
                    Phone TEXT,
                    PasswordHash TEXT,
                    ProfileImage BLOB
                );");

            // Table 3: Assignments and Task Logs Tracker
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

            // Table 4: Scheduler Storage (Powers DevExpress Scheduler UI Components)
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

            // Table 5: Shared Notice Board and System Announcements Data Stream
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS DashboardAnnouncements (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Content TEXT,
                    DatePosted TEXT,
                    Priority INTEGER DEFAULT 0
                );");

            // Table 6: Administrator Profiles and Permissions Matrix
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS Admin (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Image BLOB,
                    Student_Id TEXT,
                    FirstName TEXT,
                    LastName TEXT,
                    Email TEXT,
                    Section TEXT,
                    Date TEXT
                );");

            // Table 7: Academic Course Timetables and Room Allocation Registry
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS ClassSchedule (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Student_Id TEXT NOT NULL,
                    Title TEXT,
                    Subject TEXT,
                    Description TEXT,
                    Section TEXT,
                    Room TEXT,
                    DayOfWeek TEXT,
                    StartTime TEXT,
                    EndTime TEXT
                );");

            // 🔄 SAFE CASE-INSENSITIVE LIVE MIGRATION ROUTINE
            // Ensures columns that were added incrementally exist in older database configurations.
            try
            {
                // --- Students Table Verification ---
                var studentSectionCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('Students') WHERE UPPER(name)='SECTION';");
                if (string.IsNullOrEmpty(studentSectionCheck))
                {
                    connection.Execute("ALTER TABLE Students ADD COLUMN Section TEXT;");
                }

                // --- ClassSchedule Table Verification ---
                var csTitleCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('ClassSchedule') WHERE UPPER(name)='TITLE';");
                if (string.IsNullOrEmpty(csTitleCheck))
                {
                    connection.Execute("ALTER TABLE ClassSchedule ADD COLUMN Title TEXT;");
                }

                var csSubjectCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('ClassSchedule') WHERE UPPER(name)='SUBJECT';");
                if (string.IsNullOrEmpty(csSubjectCheck))
                {
                    connection.Execute("ALTER TABLE ClassSchedule ADD COLUMN Subject TEXT;");
                }

                var csDescriptionCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('ClassSchedule') WHERE UPPER(name)='DESCRIPTION';");
                if (string.IsNullOrEmpty(csDescriptionCheck))
                {
                    connection.Execute("ALTER TABLE ClassSchedule ADD COLUMN Description TEXT;");
                }

                var csSectionCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('ClassSchedule') WHERE UPPER(name)='SECTION';");
                if (string.IsNullOrEmpty(csSectionCheck))
                {
                    connection.Execute("ALTER TABLE ClassSchedule ADD COLUMN Section TEXT;");
                }

                var csRoomCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('ClassSchedule') WHERE UPPER(name)='ROOM';");
                if (string.IsNullOrEmpty(csRoomCheck))
                {
                    connection.Execute("ALTER TABLE ClassSchedule ADD COLUMN Room TEXT;");
                }

                var csDayOfWeekCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('ClassSchedule') WHERE UPPER(name)='DAYOFWEEK';");
                if (string.IsNullOrEmpty(csDayOfWeekCheck))
                {
                    connection.Execute("ALTER TABLE ClassSchedule ADD COLUMN DayOfWeek TEXT;");
                }

                var csStartTimeCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('ClassSchedule') WHERE UPPER(name)='STARTTIME';");
                if (string.IsNullOrEmpty(csStartTimeCheck))
                {
                    connection.Execute("ALTER TABLE ClassSchedule ADD COLUMN StartTime TEXT;");
                }

                var csEndTimeCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('ClassSchedule') WHERE UPPER(name)='ENDTIME';");
                if (string.IsNullOrEmpty(csEndTimeCheck))
                {
                    connection.Execute("ALTER TABLE ClassSchedule ADD COLUMN EndTime TEXT;");
                }

                // --- Admin Table Verification ---
                var adminEmailCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('Admin') WHERE UPPER(name)='EMAIL';");
                if (string.IsNullOrEmpty(adminEmailCheck))
                {
                    connection.Execute("ALTER TABLE Admin ADD COLUMN Email TEXT;");
                }

                var adminSectionCheck = connection.ExecuteScalar<string>("SELECT name FROM pragma_table_info('Admin') WHERE UPPER(name)='SECTION';");
                if (string.IsNullOrEmpty(adminSectionCheck))
                {
                    connection.Execute("ALTER TABLE Admin ADD COLUMN Section TEXT;");
                }
            }
            catch (SqliteException) { /* Managed gracefully */ }

            // Safe Backward-Compatibility Schema Data Migration Triggers
            try
            {
                if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM sqlite_master WHERE type='table' AND name='StudentProfile';") > 0)
                {
                    connection.Execute(@"
                        INSERT OR IGNORE INTO Students (StudentId, FullName, Email, Course, Phone, PasswordHash)
                        SELECT StudentId, FullName, Email, Course, Phone, PasswordHash FROM StudentProfile;");
                }
            }
            catch (SqliteException) { }

            try
            {
                if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM sqlite_master WHERE type='table' AND name='User';") > 0)
                {
                    connection.Execute(@"
                        INSERT OR IGNORE INTO Users (Username, Password)
                        SELECT Username, Password FROM User;");
                }
            }
            catch (SqliteException) { }

            // Safe Data Initialization: Seed testing profiles if completely empty
            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Students WHERE StudentId = @StudentId;", new { StudentId = "STU-2026-0001" }) == 0)
            {
                connection.Execute(@"
                    INSERT INTO Students (StudentId, FullName, Email, Course, Section, Phone, PasswordHash, ProfileImage)
                    VALUES (@StudentId, 'Administrator', 'admin@university.edu', 'B.S. Computer Science', 'NEUMANN', '+1 (555) 019-2834', '123', NULL);",
                    new { StudentId = "STU-2026-0001" });
            }
            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Users WHERE Username = @Username;", new { Username = "STU-2026-0001" }) == 0)
            {
                connection.Execute(@"
                    INSERT INTO Users (Username, Password)
                    VALUES (@Username, '123');",
                    new { Username = "STU-2026-0001" });
            }

            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Students WHERE StudentId = @StudentId;", new { StudentId = "2016-0474" }) == 0)
            {
                connection.Execute(@"
                    INSERT INTO Students (StudentId, FullName, Email, Course, Section, Phone, PasswordHash, ProfileImage)
                    VALUES (@StudentId, 'Khimuel Diamante', 'khimueld_diamante@dmc.edu.ph', 'IT', 'NEUMANN', '093524656', 'KhimzUgh', NULL);",
                    new { StudentId = "2016-0474" });
            }
            else
            {
                // Ensure existing records have a valid section mapped to connect dashboards properly
                connection.Execute("UPDATE Students SET Section = 'NEUMANN' WHERE StudentId = '2016-0474' AND (Section IS NULL OR Section = '');");
            }

            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Users WHERE Username = @Username;", new { Username = "2016-0474" }) == 0)
            {
                connection.Execute(@"
                    INSERT INTO Users (Username, Password)
                    VALUES (@Username, 'KhimzUgh');",
                    new { Username = "2016-0474" });
            }

            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Users WHERE Username = @Username;", new { Username = "admin" }) == 0)
            {
                connection.Execute("INSERT INTO Users (Username, Password) VALUES (@Username, '123');", new { Username = "admin" });
            }
            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM Students WHERE StudentId = @StudentId;", new { StudentId = "admin" }) == 0)
            {
                connection.Execute(@"
                    INSERT INTO Students (StudentId, FullName, Email, Course, Section, Phone, PasswordHash, ProfileImage)
                    VALUES (@StudentId, 'System Administrator', 'admin@dmc.edu.ph', 'IT Management', 'ADMIN', '00000', '123', NULL);",
                    new { StudentId = "admin" });
            }

            if (connection.ExecuteScalar<int>("SELECT COUNT(1) FROM DashboardAnnouncements;") == 0)
            {
                connection.Execute(@"
                    INSERT INTO DashboardAnnouncements (Title, Content, DatePosted, Priority)
                    VALUES ('Welcome to your Student Workspace!', 'Use the sidebar navigation tabs to monitor assignments, adjust your profile, or manage schedules.', '2026-05-28', 1);");
            }
        }
    }
}