using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediMenager krediMenager, List<ILogerService> logerServices)
        {
            krediMenager.Hesapla();
            foreach (ILogerService item in logerServices)
            {
                item.Log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediMenager> krediler)
        {
            for (int i = 0; i < krediler.Count; i++)
            {
                krediler[i].Hesapla();
            }
        }
    }
}
