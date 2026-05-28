using Microsoft.Data.Sqlite;

namespace Task_Management_System.Data
{
    public class DataBase
    {
        /// <summary>
        /// Safely routes legacy database connection requests to the modern context setup.
        /// </summary>
        public SqliteConnection GetConnection()
        {
            var con = new SqliteConnection(DatabaseContext.ConnectionString);
            con.Open();
            return con;
        }
    }
}