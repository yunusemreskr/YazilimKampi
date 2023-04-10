using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) 
        {
            //Başvuran bilgilerini değerlendir
            //
            //
            krediManager.Hesapla();
            foreach (var logger in loggerServices) 
            {
                logger.Log();

            }
        
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
