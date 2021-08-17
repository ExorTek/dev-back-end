using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Category4 { get; set; }
        public string Brand { get; set; }

    }
}
