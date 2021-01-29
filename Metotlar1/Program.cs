using System;

namespace Metotlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15.67;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Ayva";
            urun2.Fiyati = 11.67;
            urun2.Aciklama = "Geyve Ayvası";

            Urun urun3 = new Urun();
            urun3.Adi = "Zeytin";
            urun3.Fiyati = 25;
            urun3.Aciklama = "Burhaniye Zeytini";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Adı : " + urun.Adi);
                Console.WriteLine("Fiyatı : " + urun.Fiyati);
                Console.WriteLine("Açıklaması : "+ urun.Aciklama);
                Console.WriteLine("---------");
                
            }
            Console.WriteLine("-----Metotlar----");
            SepetManager1 sepetManager1 = new SepetManager1();
            sepetManager1.Ekle(urun1);
            sepetManager1.Ekle(urun2);
            


        }
    }
}
