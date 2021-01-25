using InterfaceAbstractDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo1.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
