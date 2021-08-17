using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class Address : IEntity
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public byte CountryId { get; set; }
        public short CityId { get; set; }
        public int TownId { get; set; }
        public int DistrictId { get; set; }
        public string PostalCode { get; set; }
        public string AddressText { get; set; }
    }
}