using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Dictionary_Course
    {
        void dictionary()
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();

            myDictionary.Add("dictionary", "sozluk");
            myDictionary.Add("key", "anahtar");
            myDictionary.Add("value", "değer");

            Console.WriteLine(myDictionary["dictionary"]);
            Console.ReadLine();
            
        }
    }
}
