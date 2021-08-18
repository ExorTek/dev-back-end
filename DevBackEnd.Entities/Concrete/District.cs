using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class District:IEntity
    {
        public virtual int DistrictId { get; set; }
        public virtual int TownId { get; set; }
        public virtual string DistrictName { get; set; }

    }
}
