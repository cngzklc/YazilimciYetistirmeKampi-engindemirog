using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Geçerli kişi değil");
                //throw new Exception("Not a valid person");//Gerçerli bir kişi değil
            }
        }

    }
}
