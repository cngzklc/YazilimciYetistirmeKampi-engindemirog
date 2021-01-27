using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.MernisServiceReference;
using System;

namespace InterfaceAbstractDemo.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        // "https://tckimlik.nvi.gov.tr/service/kpspublic.asmx?wsdl" adresini Project\Service Reference\ kısmına yapıştırarak ekliyoruz.
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastNme.ToUpper(), customer.DateOfBirt.Year);
        }
    }
}
