using InterfaceAbstractDemo1.Abstract;
using InterfaceAbstractDemo1.Entities;
using InterfaceAbstractDemo1.MernisServiceReference;
using System;

namespace InterfaceAbstractDemo1.Adapter
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
