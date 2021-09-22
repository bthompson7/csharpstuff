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

            //http request
            if (args[1].Equals("http"))
            {
               HttpProgram httpProgram = new HttpProgram();
               httpProgram.run();

            }

            //connect to a mysql database and run a simple query
            else if (args[1].Equals("db"))
            {
                DbProgram dbProgram = new DbProgram();
                dbProgram.run();
            }else{
                Console.WriteLine("Not a valid argument");
            }





        }

    }


}
