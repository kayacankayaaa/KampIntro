using System;

namespace Donguler1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kursAdi1 = "Java";
            string kursAdi2 = "C#";
            string kursAdi3 = "Phyton";


            Console.WriteLine(kursAdi1);
            Console.WriteLine(kursAdi2);
            Console.WriteLine(kursAdi3);
            Console.WriteLine("------foreach------");

            string[] kurslar = new string[] {kursAdi1,kursAdi2,kursAdi3,"C++" };

            foreach (string kurs in kurslar)
            {
                
                Console.WriteLine(kurs);
            }



        }
    }
}
