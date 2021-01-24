using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        private IEnumerable<object> loggerServices;

        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService>loggerService)
            
        {
            krediManager.Hesapla();
            foreach (var LoggerService in loggerServices)
            {
                loggerService.Log();
            }

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(IKrediManager ihtiyacKrediManager, object databaseLoggerService)
        {
            throw new NotImplementedException();
        }
    }
}
