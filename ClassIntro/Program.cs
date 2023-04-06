internal class Program
{
    private static void Main(string[] args)
    {
        string adi = "Yunus";
        int yas = 24;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Yunus Emre Şeker";
        kurs1.IzlenmeOrani = 75;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "İrem Çoban";
        kurs2.IzlenmeOrani = 80;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Günnur Aksoy";
        kurs3.IzlenmeOrani = 77;

        //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
        }

        

        //Console.WriteLine("Hello, World!");
    }
}


class Kurs
{
    public string KursAdi { get; set; }

    public string Egitmen { get; set; }

    public int IzlenmeOrani { get; set; }


}