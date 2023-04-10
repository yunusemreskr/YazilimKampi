using OOP3;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();

        ILoggerService databaseLoggerService = new DataBaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();

        List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(), new FileLoggerService()  };

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);

        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager, konutKrediManager };

        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



    }
}