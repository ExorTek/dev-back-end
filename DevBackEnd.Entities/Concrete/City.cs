using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class City:IEntity
    {
        public virtual int CityId { get; set; }
        public virtual byte CountryId { get; set; }
        public virtual string CityName { get; set; }
    }
}
