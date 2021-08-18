using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class Product:IEntity
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductCode { get; set; }
        public virtual string ProductName { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual string Category1 { get; set; }
        public virtual string Category2 { get; set; }
        public virtual string Category3 { get; set; }
        public virtual string Category4 { get; set; }
        public virtual string Brand { get; set; }

    }
}
