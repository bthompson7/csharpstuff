using MySql.Data.MySqlClient;
using System;

namespace csharp
{
    class DbProgram
    {

        public DbProgram()
        {

        }
        public void run()
        {


            string query = "select * from user limit 15";

            DatabaseManager db = new DatabaseManager("localhost", "db_example", "admin", "password");

            var cmd = new MySqlCommand(query, db.getConnection());

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string someStringFromColumnZero = reader.GetString(0);
                string someStringFromColumnOne = reader.GetString(1);
                Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
            }

            db.close();



        }

    }


}
