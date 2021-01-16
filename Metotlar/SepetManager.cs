using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax
        //Metotlar büyük harf ile başlar
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
