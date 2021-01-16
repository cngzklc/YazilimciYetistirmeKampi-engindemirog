using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        // nameing convention
        //syntax
        //encapsulation : kapsülleme : Bir nesne oluşturup özellik tanımlamaya denir. 
        //Nesne oluşturmadan tanımlanan property'lere değer atamak kapsülleme olmuyor.

        public void Ekle(Urun urun)
        {
            Console.WriteLine("{0} Sepete Eklendi",urun.Adi);
        }
    }
}
