using InterfaceAbstractDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo1.Abstract
{
    interface ICustomerService
    {
        void Save(Customer customer);
    }
}
