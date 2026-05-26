using Microsoft.Data.Sqlite;
using System;

namespace Task_Management_System.Data
{
    public class DataBase
    {
        private string connectionString =
            $"Data Source={AppDomain.CurrentDomain.BaseDirectory}Data\\DB_TaskManagement.db;";

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }

        // ✅ Call this once on app startup
        public void InitializeDatabase()
        {
            using (SqliteConnection con = GetConnection())
            {
                con.Open();

                string createStudentTask = @"
                    CREATE TABLE IF NOT EXISTS StudentTask (
                        StudentID TEXT PRIMARY KEY,
                        FirstName TEXT,
                        LastName  TEXT,
                        Section   TEXT,
                        Date      TEXT,
                        Photo     BLOB
                    )";

                string createStudentLogin = @"
                    CREATE TABLE IF NOT EXISTS StudentLogin (
                        StudentID TEXT PRIMARY KEY,
                        Username  TEXT UNIQUE,
                        Password  TEXT,
                        FOREIGN KEY (StudentID) REFERENCES StudentTask(StudentID)
                    )";

                string createUser = @"
                    CREATE TABLE IF NOT EXISTS User (
                        Username TEXT PRIMARY KEY,
                        Password TEXT,
                        Role     TEXT DEFAULT 'Admin'
                    )";

                new SqliteCommand(createStudentTask, con).ExecuteNonQuery();
                new SqliteCommand(createStudentLogin, con).ExecuteNonQuery();
                new SqliteCommand(createUser, con).ExecuteNonQuery();

                // ✅ Insert default admin if not exists
                string insertAdmin = @"
                    INSERT OR IGNORE INTO User (Username, Password, Role)
                    VALUES ('admin', 'admin123', 'Admin')";

                new SqliteCommand(insertAdmin, con).ExecuteNonQuery();
            }
        }
    }
}