using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyaçKrediManager = new İhtiyaçKrediManager();
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyaçKrediManager,fileLoggerService);


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyaçKrediManager, taşıtKrediManager };

            //basvuruManager.KrediOnBilgilenDirilmesiYay(krediler);



        }
    }
}
