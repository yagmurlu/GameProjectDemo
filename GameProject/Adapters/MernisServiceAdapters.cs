using GameProject.MernisServiceReference;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Adapters
{
    public class MernisServiceAdapters
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalityId),
                gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.DateOfBirth.Year);
        }
    }
}
