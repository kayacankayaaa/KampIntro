using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Kayacan";
            musteri1.DogumAyi = "Ekim";
            musteri1.MussteriId = 1;
            musteri1.SoyAd = "Kaya";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Fevzi";
            musteri2.DogumAyi = "Ocak";
            musteri2.MussteriId = 2;
            musteri2.SoyAd = "Bilir";

            MusteriManager musteri = new MusteriManager();
            musteri.Ekle(musteri1);
            musteri.Cikar(musteri2);
            musteri.Listele(musteri1);
            musteri.Listele(musteri2);


        }
    }
}
