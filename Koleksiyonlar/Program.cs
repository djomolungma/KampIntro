using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ctrl + k Ctrl + c     //satırları önce seç + comment satırı yap
            //Ctrl + k Ctrl + u     //satırları önce seç + comment satırı geri al

            //dizi örneği
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            // diziler sabit uzunlukta olduğu için koleksiyonlar devreye girer
            // koleksiyonlara istediğiniz kadar eleman ekleyebilirsiniz boyutu sabit değildir

            //koleksiyon örneği 1
            List<string> isimler2 = new List<string>();
            isimler2.Add("Ali");
            isimler2.Add("Veli");
            isimler2.Add("Selami");

            //koleksiyon örneği 2
            List<string> isimler3 = new List<string> { "Ali", "Veli", "Selami"};

            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            isimler3.Add("Osman");
            Console.WriteLine(isimler3[3]);
            Console.WriteLine(isimler3[0]);


        }
    }
}
