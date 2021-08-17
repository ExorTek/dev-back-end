using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class Country : IEntity
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}