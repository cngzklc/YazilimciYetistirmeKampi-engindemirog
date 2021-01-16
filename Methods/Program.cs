using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun { Adi = "Elma", Fiyati = 5, Aciklama = "Amasya Elması" };
            Urun urun2 = new Urun { Adi = "Armut", Fiyati = 7, Aciklama = "Deveci Armutu" };
            Urun urun3 = new Urun { Adi = "Karpuz", Fiyati = 20, Aciklama = "Diyarbakır" };

            Urun[] Urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in Urunler)
            {
                Console.WriteLine("Adı = {0}", urun.Adi);
                Console.WriteLine("Fiyatı = {0} Lira", urun.Fiyati.ToString());
                Console.WriteLine("Açıklama = {0}\n", urun.Aciklama);
            }

            Console.WriteLine("...................Metodlar............");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);





            Console.ReadLine();
        }
    }
}


//Dont repeat yourself (DRY): Kendini tekrar etME prensibi : Aynı kodo farklı yerlerde yazmamak anlamında. 
//Clean Code : Temiz kod
//Best Practice: Doğru (En iyi) uygulama teknikleri