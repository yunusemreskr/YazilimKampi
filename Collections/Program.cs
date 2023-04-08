using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> isimler2 = new List<string> {"Yunus", "İrem", "Emre", "Şeker", "Çoban"};
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);
        isimler2.Add("Zeynep");
        Console.WriteLine(isimler2[5]);
        Console.WriteLine(isimler2[0]);



    }
}