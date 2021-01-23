using System;

namespace OOP3
{
    //Anahtarı aç ve move type to FileLoggerService.cs çift tıkla
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
