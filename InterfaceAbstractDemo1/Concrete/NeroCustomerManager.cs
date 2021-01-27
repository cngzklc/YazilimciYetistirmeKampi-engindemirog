using InterfaceAbstractDemo1.Abstract;
using InterfaceAbstractDemo1.Entities;
using System;

namespace InterfaceAbstractDemo1.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        #region Nero kimlik doğrulama istemediği için aşağıdaki kodlara gerek yok.
        private ICustomerCheckService _customerCheckService;
        public NeroCustomerManager(ICustomerCheckService customerCheckService)
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
        #endregion

    }
}
