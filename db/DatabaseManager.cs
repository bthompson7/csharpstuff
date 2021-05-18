using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace csharp
{
    public class DatabaseManager
    {

        private string server { get; set; }
        private string dbName { get; set; }
        private string user { get; set; }
        private string pass { get; set; }

        private MySqlConnection connection { get; set; }
        public DatabaseManager(string server, string dbName, string user, string pass)
        {
            string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", server, dbName, user, pass);
            connection = new MySqlConnection(connstring);
            connection.Open();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void close()
        {
            connection.Close();
        }


    }


}