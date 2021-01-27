using InterfaceAbstractDemo1.Abstract;
using InterfaceAbstractDemo1.Concrete;
using InterfaceAbstractDemo1.Entities;
using InterfaceAbstractDemo1.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer() { Id = 1, FirstName = "Cengiz", LastNme = "Kılıç", DateOfBirt = new DateTime(1985, 8, 7), NationalityId = "25684908800" });
            Console.ReadLine();
        }
    }
}
