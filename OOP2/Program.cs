using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri() { Id = 1, MusteriNo = "123456", Adi = "Cengiz", Soyadi = "Kılıç", TcNo = "25684908800" };
            TuzelMusteri musteri2 = new TuzelMusteri() { Id = 2, MusteriNo = "23266", SirketAdi = "Kodlama.io", VergiNo = "8717715" };
            Musteri musteri3 = new GercekMusteri() { Id = 1, MusteriNo = "123456", Adi = "CAn", Soyadi = "Kılıç", TcNo = "34617216516" };
            Musteri musteri4 = new TuzelMusteri() { Id = 2, MusteriNo = "23266", SirketAdi = "Discord", VergiNo = "841163" };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

        }
    }
}
