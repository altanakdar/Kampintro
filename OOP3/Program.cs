using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        private static TasitKrediManager tasitKrediManager;

        static void Main(string[] args)
        {
           IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
        
           IKrediManager tasitKrediManager = new TasitKrediManager();
          
           IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerServise = new FileLoggerService();
           
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService() });
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
               
            
            
        }
    }
}
