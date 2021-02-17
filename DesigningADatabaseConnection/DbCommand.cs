using System;
using System.Collections.Generic;
using System.Text;

namespace DesigningADatabaseConnection
{
    class DbCommand
    {
        /* DB command is valid state only if you have a connection
         * Exception is thrown if it is in invalid state
         * DbCommand will sent the instruction to the database.
         * 
         */

        private readonly string _intruction;
        private readonly DbConnection _connection;
        public DbCommand(DbConnection connection, string instruction) 
        {
            if (connection == null ) 
            {
                throw new InvalidOperationException(" The connection was null");
            }
            if (instruction == null || string.IsNullOrWhiteSpace(instruction)) 
            {
                throw new InvalidOperationException("Invalid instruction(Null or empty string)");
            }
            _intruction = instruction;
            _connection = connection;
            Execute();
           
        }
        public void Execute() 
        {
            TimeSpan Time = new TimeSpan(DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes, DateTime.Now.TimeOfDay.Seconds);
            _connection.OpenConnection(Time);
            _runInstruction();
            _connection.CloseConnection();

        }
        private void _runInstruction() 
        {
            Console.WriteLine("\n\nRunning the instructions .....");
            Console.WriteLine("Instruction "+_intruction);
            Console.WriteLine("Instruction run was successful.\n\n");

        }
    }
}
