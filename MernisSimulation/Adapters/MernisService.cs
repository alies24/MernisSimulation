using MernisReference;
using MernisSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisSimulation.Concrete
{
    public class MernisService : ICheckService
    {
     
        public bool Check(Person person)
        {
            var mernisClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync
                (Convert.ToInt64(person.NationalityId), person.FirstName.ToUpper(), person.LastName.ToUpper(), person.BirthYear).GetAwaiter().GetResult();
            return tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;

        }
    }
}
