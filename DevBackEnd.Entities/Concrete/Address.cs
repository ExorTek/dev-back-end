using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class Address : IEntity
    {
        public virtual int AddressId { get; set; }
        public virtual int UserId { get; set; }
        public virtual byte CountryId { get; set; }
        public virtual short CityId { get; set; }
        public virtual int TownId { get; set; }
        public virtual int DistrictId { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string AddressText { get; set; }
    }
}