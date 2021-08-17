using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
   public class City:IEntity
    {
        public int CityId { get; set; }
        public byte CountryId { get; set; }
        public string CityName { get; set; }
    }
}
