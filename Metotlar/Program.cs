using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        Product urun1 = new Product();
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya elması";

        Product urun2 = new Product();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Product urun3 = new Product();
        urun3.Adi = "Fındık";
        urun3.Fiyati = 60;
        urun3.Aciklama = "Ordu fındığı";

        Product[] products = new Product[] {urun1, urun2, urun3};

        //type - safe 
        foreach (Product product in products) 
        {
            //Console.WriteLine(product.Adi + " : " + product.Fiyati);
            Console.WriteLine("Adi: " + product.Adi);
            Console.WriteLine("Fiyati: " + product.Fiyati);
            Console.WriteLine("Ozellik: " + product.Aciklama);
            Console.WriteLine("-----------------------");
        }

        Console.WriteLine("---------Metotlar-------");

        //instance - örnek
        //encapsulation

        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        sepetManager.Ekle(urun3);


        sepetManager.Ekle2("Armut", "Yeşil armut",12, 15);
        sepetManager.Ekle2("Elma", "Yeşil elma", 12, 16);
        sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 14);




    }
}



//Dont repeat yourself! - DRY - Clean Code - Best Practice 