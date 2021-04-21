using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService  //ILoggerService alternatifisin diyoruz burda
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
