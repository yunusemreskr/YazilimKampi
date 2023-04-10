using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Yunus Emre Şeker
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.Id = 1;
        musteri1.MusteriNo = "1234";
        musteri1.Adi = "Yunus Emre";
        musteri1.Soyadi = "Şeker";
        musteri1.TcNo = "12345678910";

        //No.211
        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "4321";
        musteri2.SirketAdi = "No.211";
        musteri2.VergiNo = "1234567";


        Musteri musteri3 = new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2);


    }
}