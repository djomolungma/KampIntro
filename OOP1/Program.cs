using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//Mobilya olsun
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInSrock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, 
                ProductName = "Kalem", UnitPrice = 35, UnitInSrock = 5  };

            //C# is case sensitive language
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);//product class olduğu için yani referans tipi olduğu için çıktı "Kamera olacak" (Add() fonksiyonu içerisinde değişti)

            //int, double, bool ... değer tip
            //diziler, class, abstract class, interface ... referans tip
            //ref out 
        }
    }
}
