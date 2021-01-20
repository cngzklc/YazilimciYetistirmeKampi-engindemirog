using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        /* 
         * Add() metodu çalıştığı zaman bilgileri tutmak için Yukarıda "T" tipinde private items dizisi oluşturduk. Ama sadece oluşturduk. İçi boş. 
         * MyList class'ının Constructors'ı ile items dizisini new'leyerek sıfırıncı alanı oluşturmuş olduk. 
         * Add() metodu içerisine geçici "T" tipinde bir dizi (tempArray) oluşturup private items'ı geçici olarak tempArray'de tutmuş olduk.
        Çünkü Constructors içerisinde new dediğimiz için, items array'inin içerisindeki değerler silinerek yeni bir satır eklemiş oluyoruz.
         * Add() metodu içerisinde items array'ini new'leyerek eleman sayısna +1 ilave ederek eleman sayısını arttırıyoruz. 
        Fakat new'lendiği için items'ın içi boştur. Sadece array'in uzunluğunu arttırmış olduk. items'ın içi boşalmadan önce, items içindeki
        değerleri tempArray dizisine atamıştık zaten.
         * Add() metodu içerisinde for döngüsü oluşturarak, tempArray dizisi içerisindeki değerleri tekrar items dizisi içerisine aktarıyoruz.
         * Add() metoduna parametre ile gelen item değerini, items array'inin sonucu satırına eşitliyoruz. Böylelikle listemize bir satır veri eklemiş oluyoruz.
        */
        MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
        public int Length { get { return items.Length; } }
    }
}
