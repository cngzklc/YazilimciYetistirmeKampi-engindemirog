using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;  //MyList class'ı içerisine "T" tipinde private items dizisi oluşturduk. Ama sadece oluşturduk. İçi boş.
       public MyList()
        {
            items = new T[0]; //MyList class'ı new'lenerek örneği oluşturulduğunda Constructors'ı ile items dizisi de new'lenmiş oluyor ve sıfır elemanlı (yani lenght'i de sıfır) bir dizi oluşmuş oldu.
            //Dizileri oluşturmak için,dizinin kaç elemanlı olduğunu belirmek gerekir. Bu yüzden Constructors içerisinde dizinin uzunluğunu belirtmiş olduk. 0 elemanlı bir dizi oluştu.
        }
        public void Add(T item)
        {
            T[] tempArray = items; /* New'lenen MyList'in Add() metodu çalıştırıldığında; geçici "T" tipinde bir dizi (tempArray) oluşturmuş oluyoruz.
                                    * Sonrasında items'ı geçici olarak tempArray'de tutmuş olduk. */
            items = new T[items.Length + 1]; /* items array'ini new'leyerek eleman sayısna +1 ilave ederek eleman sayısını arttırıyoruz. Artık 1 elemanlı boş bir items dizisi oldu.
                                              * ikinci kez add() metodu çalıştıysa 2 elemanlı boş bir items dizisi olmuş oldu. Seneryo ilk kez çalıştırılan add() metodu üzerinden devam ediyor.
                                              * Fakat new dediğimiz için items içerisindeki önceki satırlara ait bilgiler silindi. 1 elemanlı bir boş bir T tipinde dizi olmuş oldu.*/
            for (int i = 0; i < tempArray.Length; i++) /* for döngüsü oluşturarak, tempArray dizisi içerisindeki değerleri tekrar items dizisi içerisine aktarıyoruz.
                                                        * İlk kez add() metodu çalıştırıldığında tempArray dizisinin uzunluğu sıfır olduğu için döngüye girmeyecektir. */
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //T tipinde gelen item'ı, items dizisinin sonuncu elemanına eşitliyoruz. 
                                            // Böylelikle T tipindeki items dizisi içerisinde tüm bilgileri tutmuş oluyoruz.
        }
        public int Length { get { return items.Length; } }
    }
}
