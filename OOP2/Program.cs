﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ayhan";
            musteri1.Soyadi = "Yıldız";
            musteri1.TcNo = "11111111111";

            //Tüzel müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12346";
            musteri2.SirketAdi = "Probar";
            musteri2.VergiNo = "1234567890";

            //Gerçek müşteri- Tüzel müşteri
            //SOLID 'in L harfi bunu söylüyor

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

        }
    }
}
