using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet = hazır kodlar
    //Bu tip klaslarda sadece özellik olur (Entity'lerde)
    class Product //Entity
    {
        public int Id { get; set; } //Primary Key
        public int CategoryId { get; set; } //Forefn Key (referans alan) //kodun okunurluğunu arttırmak için primary key den sonra yazıyoruz
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInSrock { get; set; }//Ürünün stok adedi

        //CRUD (Create, Read, Update, Delete) operasyonları
    }
}
