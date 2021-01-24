using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Logg()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
