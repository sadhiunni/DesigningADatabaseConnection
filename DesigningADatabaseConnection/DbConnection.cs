using System;
using System.Collections.Generic;
using System.Text;

namespace DesigningADatabaseConnection
{
    public abstract class DbConnection
    {
        /*The common functionalities are written in this class
         */
        private readonly string _connectionString;
        private  TimeSpan _timeOut;
        public DbConnection(string connection) 
        {
            _connectionString = connection;
        }

        public TimeSpan TimeOut() 
        {
              _timeOut = new TimeSpan(0, 0, 15);
                return _timeOut;
        }
        public abstract void OpenConnection(TimeSpan startTime);
        public abstract void CloseConnection();
    }
}
