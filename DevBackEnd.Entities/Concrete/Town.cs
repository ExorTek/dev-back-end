using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class Town : IEntity
    {
        public virtual int TownId { get; set; }
        public virtual short CityId { get; set; }
        public virtual string TownName { get; set; }
    }
}