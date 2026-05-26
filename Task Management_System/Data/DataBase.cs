using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Data
{
    public class DataBase
    {
        private string connectionString = $"Data Source={AppDomain.CurrentDomain.BaseDirectory}Data\\DB_TaskManagement.db;";

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }
    }
}