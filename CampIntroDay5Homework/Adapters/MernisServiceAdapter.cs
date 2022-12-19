using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CampIntroDay5Homework.Adapters
{
    public class MernisServiceAdapter : IMernisService
    {
        public bool CheckIfRealPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(person.NationalityId), person.FirstName, person.LastName, person.DateOfBirth.Year);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
