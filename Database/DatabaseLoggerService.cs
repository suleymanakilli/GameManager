using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingGameBackend
{
    class DatabaseLoggerService:ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Data has been saved to the Database!\n");
        }
    }
}
