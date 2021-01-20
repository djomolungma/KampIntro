using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager//ProductService de denebilirdi
    {
        //ProductService de denebilirdi
        //Ürünle ilgili operasyonlar burada
        //Ekleme, silme, güncelleme, filtreleme

        //encapsulation = bir sürü vari parametre olarak vermek yerine tek bir sınıf gönderyoruz
        public void Add(Product product) 
        {
            //product.ProductName = "Kamera";//product class olduğu için yani referans tipi olduğu için çıktı "Kamera olacak"
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }        

    }
}
