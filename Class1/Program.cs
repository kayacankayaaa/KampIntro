using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Kayacan";
            int yas = 26;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Fevzi";
            kurs1.IzlenmeOrani = 31;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Ahmet";
            kurs2.IzlenmeOrani = 41;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Mert";
            kurs3.IzlenmeOrani = 47;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            //Console.WriteLine(kurs2.KursAdi + " : " + kurs1.Egitmen);
            //Console.WriteLine(kurs3.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
