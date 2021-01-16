using System;

//tekrar tekrar kullanılabilirligi saglayan yapılar
//Dont repeat yourself - DRY - Clean code - Best practice (Dogru uygulama teknikleri)

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";

            Urun[] urunler = new Urun[] { urun1,urun2};

            //type safe - tip güvenli c#
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------------");
            }

            //cw tab + tab
            Console.WriteLine("--------------------Metotlar------------------------");

            //instance - class örneği
            //encapsulation - kapsulleme örn Ekle ve Ekle2 arasındaki farklara bak Ekle uygun bie şekilde encapsuleedilmiştir

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //encapsulation var
            sepetManager.Ekle(urun2); //encapsulation var

            sepetManager.Ekle2("Armut", "Ham", 12, 10); //encapsulation yok
            sepetManager.Ekle2("Elma", "Ham", 15, 9); //encapsulation yok
            Console.WriteLine("--------------------Metotlar---------------------son");

        }
    }
}
