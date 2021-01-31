using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri1)
        {
            Console.WriteLine(musteri1.Ad +" " + musteri1.SoyAd + " İsimli Müşteri Dataya Eklenmiştir.");
            Console.WriteLine("---------- Müşteri Ekleme ---------");
        }
        public void Cikar(Musteri musteri2)
        {
            Console.WriteLine(musteri2.Ad + " " + musteri2.SoyAd + " İsimli Müşteri Datadan Çıkartılmıştır.");
            Console.WriteLine("---------- Müşteri Çıkarma ---------");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı: " + musteri.Ad);
            Console.WriteLine("Müşteri SoyAdı: " + musteri.SoyAd);
            Console.WriteLine("Müşteri Doğum ayı: " + musteri.DogumAyi);
            Console.WriteLine("---------- Müşteri Listeleme ---------");
        }


    }
}
