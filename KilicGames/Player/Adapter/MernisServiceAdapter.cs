using KilicGames.MernisServiceReference;
using KilicGames.Player.Abstract;
using KilicGames.Player.Entities;
using System;

namespace KilicGames.Player.Adapter
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        // "https://tckimlik.nvi.gov.tr/service/kpspublic.asmx?wsdl" adresini Project\Add Service Reference\ kısmına yapıştırarak ekliyoruz.
        public bool CheckIfRealPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(person.NationalityId),
                person.FirstName,
                person.LastName.ToUpper(),
                person.DateOfBirt.Year);
        }
    }
}
