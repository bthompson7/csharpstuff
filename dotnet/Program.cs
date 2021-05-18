using MySql.Data.MySqlClient;
using System;

namespace csharp
{
    class Program
    {

        static void Main(string[] args)
        {

            if (args.Length == 1)
            {
                throw new Exception("Please enter either http or db");
            }

            if (args[1].Equals("http"))
            {
                //http requests
                HttpRequests httpRequests = new HttpRequests();
                httpRequests.makeGetRequest("Ben");

            }

            //connect to a mysql database
            else if (args[1].Equals("db"))
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
            }else{
                Console.WriteLine("Not a valid argument");
            }





        }

    }


}
