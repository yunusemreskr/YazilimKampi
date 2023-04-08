using OOP1;

internal class Program
{
    private static void Main(string[] args)
    {

        Product product1 = new Product();
        product1.Id = 1;
        product1.CategoryId = 2;
        product1.ProductName = "Masa";
        product1.UnitPrice = 500;
        product1.UnitsInStock = 3;

        Product product2 = new Product { Id = 2, UnitsInStock= 8, UnitPrice = 45, CategoryId= 4, ProductName="Kalem" };

        // PascalCase   //camelCase
        // Case sansitive

        ProductManager productManager = new ProductManager();
        productManager.Add(product1);
        Console.WriteLine(product1.ProductName);

        




    }
}