using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class City:IEntity
    {
        public virtual short CityId { get; set; }
        public virtual int CountryId { get; set; }
        public virtual string CityName { get; set; }
    }
}
