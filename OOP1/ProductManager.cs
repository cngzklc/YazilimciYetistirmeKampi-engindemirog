using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //PascalCase = Kelimelerin ilk harfi büyük
        //CamelCase = Kelimenin ilkharfi küçük, sonraki kelimelerin ilk harfi büyük
        public void Add(Product product)
        {
            Console.WriteLine("{0} eklendi", product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("{0} güncellendi", product.ProductName);
        }
    }
}
