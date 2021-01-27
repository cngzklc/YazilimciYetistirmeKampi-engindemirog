using KilicGames.Abstract;
using KilicGames.Entities;
using KilicGames.MernisServiceReference;
using System;

namespace KilicGames.Adapter
{
    class MernisServiceAdapter : IPlayerCheckService
    {
        // "https://tckimlik.nvi.gov.tr/service/kpspublic.asmx?wsdl" adresini Project\Add Service Reference\ kısmına yapıştırarak ekliyoruz.
        public bool CheckIfRealPerson(Player customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(customer.NationalityId), 
                customer.FirstName, 
                customer.LastName.ToUpper(), 
                customer.DateOfBirt.Year);
        }
    }
}
