using OOP3;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();

        BasvuruManager basvuruManager = new BasvuruManager();
        //basvuruManager.BasvuruYap(ihtiyacKrediManager);

        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager, konutKrediManager  };

        basvuruManager.KrediOnBilgilendirmesiYap(krediler);

    }
}