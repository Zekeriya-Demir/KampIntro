using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Logg()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
