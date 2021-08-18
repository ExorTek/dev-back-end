using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class InvoiceDetail:IEntity
    {
        public virtual int InvoiceDetailId { get; set; }
        public virtual int InvoiceId { get; set; }
        public virtual int OrderDetailId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int Amount { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual decimal LineTotal { get; set; }
    }
}
