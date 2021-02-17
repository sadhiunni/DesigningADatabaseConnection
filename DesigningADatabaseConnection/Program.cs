using System;

namespace DesigningADatabaseConnection
{
    /* Designing a Database connection Concept.Just to understand the concept of Polymorphism 
     * Connecting to a database depends on the type of the target database(Eg : SQL ,Oracle)
     * Both these connections have a few things in common:
        • They have a connection string
        • They can be opened
        • They can be closed
        • They may have a timeout attribute (so if the connection could not be opened within the
          timeout, an exception will be thrown).
     * If the DBConnection is not in a valid state (If connection string is not valid) - throw an exception 
     */
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Database Connection");
            Console.WriteLine("Enter the connection string");
            var connection = Console.ReadLine();
 
            Console.WriteLine("Enter the instruction string");
            var instruction = Console.ReadLine();
            
            Console.WriteLine("Choose connection \nOracle \nSql ");
            var connectiontype = Console.ReadLine();

            switch (connectiontype.ToLower())
            {
                case "oracle":
                    DbCommand orcDbCmd = new DbCommand(new OracleConnection(connection),instruction);
                    break;
                case "sql":
                    DbCommand sqlDbCmd = new DbCommand(new OracleConnection(connection), instruction);
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}
