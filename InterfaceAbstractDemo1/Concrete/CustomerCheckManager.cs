using InterfaceAbstractDemo1.Abstract;
using InterfaceAbstractDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo1.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
