using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuran bilgileri değerlendirme

            krediManager.Hesapla();
            loggerService.log();
        }
        public void KrediOnBilgilenDirilmesiYay(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(IKrediManager ihtiyaçKrediManager)
        {
            throw new NotImplementedException();
        }
    }
}
