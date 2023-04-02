using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace dataBaseViking
{
    public class DataBase
    {
        private static DataBase instance;
        protected DataBase()
        { }
        public static DataBase getInstance()
        {
            if (instance == null)
            {
                instance = new DataBase();
                return instance;
            }
            else
            {
                return null;
            }
        }
        static string pathToDatabase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vikingDB.db");
        SQLiteConnection connection = new SQLiteConnection("Data Source=" + pathToDatabase + ";Version=3; FailIfMissing=True");
        public SQLiteConnection getConnection()
        {
            return connection;
        }
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public string ToDateSQLite(DateTime value)
        {
            string format_date = "yyyy-MM-dd";
            return value.ToString(format_date);
        }
    }
}
