using System;
using System.Collections.Generic;
using System.Text;

namespace DesigningADatabaseConnection
{
    class SqlConnection : DbConnection
    {
        string Connection;
        public SqlConnection(String connection) 
            :base(connection)
        {
            Console.WriteLine("Sql Connection ......");
             Connection = connection;
        }
        public override void OpenConnection(TimeSpan StartTime) 
        {
            Console.WriteLine("Do you want to connect");
            var connect = Console.ReadLine();
            if (Connection == null || Connection == "")
            {
                throw new InvalidOperationException("Please enter a valid Connection String for the sql database");
            }
            if (connect.ToLower()=="yes")
            {
                TimeSpan ConnectedTime = new TimeSpan(DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes, DateTime.Now.TimeOfDay.Seconds);
                Console.WriteLine("StartTime :"+StartTime);
                Console.WriteLine("Connected to dataBase, Time :"+ConnectedTime);
                Console.WriteLine("Difference in time span is :"+(ConnectedTime-StartTime) );
                if (ConnectedTime - StartTime >= TimeOut())
                {
                    throw new InvalidOperationException("The connection has timed out(15 sec crossed) .Please try again later.");
                }
                else
                {
                    Console.WriteLine("SQL Database Connection Opened");

                }
            }

            else
            {
                Console.WriteLine("Connection closed");
                throw new InvalidOperationException("Exiting....");
            }

        }
        public override void CloseConnection() 
        {
            Console.WriteLine("SQL Database Close connection");
        }

    }
}
