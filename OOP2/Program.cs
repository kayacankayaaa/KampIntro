using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kayacan Kaya
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Kayacan";
            musteri1.Soyadi = "Kaya";
            musteri1.TcNo = "12345678910";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek - Tüzel > Gerçek kişiye şirket adı tanımlanmayabilir. 
            //SO'L'ID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //musteri classi hem tüzel hem gerçek müşteri referansını tutabiliyor.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
