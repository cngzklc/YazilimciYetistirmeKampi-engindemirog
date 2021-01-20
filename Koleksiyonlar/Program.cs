using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]);
            /*  5.elemanı sonradan oluşturduğumuzda hata verecektir. Sebebi de isimler dizisi başta 4 elemanlı olarak oluşturuldu.
            sonradan 5. elemanı tanımladığımızda alan dışında olacaktır ve System.IndexOutOfRangeException hatası verecektir*/
            isimler = new string[5]; 
            /*  isimler dizisini sonradan 5 elemanlıya çevirdiğimizde ve 5. elemanını değer atadığımızda program çalışacaktır.
            fakat aşağıdaki gibi 0. ve 1. elemanları ekrana yazdırdığımızda, ekrana boş gelecektir. Çünkü new string[5] diyerek, yeni 5 elemanlı bir string 
            dizi oluşturmuş oluyoruz. ve sonrasında 4. elemanına ilker atadığımız için 4. elemanı ekrana yazdırabiliyoruz.
            Ama 0 ve 1. elemanlar halen boştur. Çünkü yeni bir değer atamadık.*/
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.ReadLine();

        }
    }
}
