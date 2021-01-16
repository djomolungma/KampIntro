using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Java";
            string kurs2 = "C#";

            //array - dizi
            string[] kurslar = new string[] { "Java" , "C#","C++"};
            

            for (int i = 0; i < kurslar.Length; i ++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti...");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}
