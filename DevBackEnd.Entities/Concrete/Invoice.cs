using DevBackEnd.Core.Entities;
using System;

namespace DevBackEnd.Entities.Concrete
{
    public class Invoice : IEntity
    {
        public virtual int InvoiceId { get; set; }
        public virtual int OrderId { get; set; }
        public virtual DateTime InvoiceDate { get; set; }
        public virtual int AddressId { get; set; }
        public virtual string CargoFicheNo { get; set; }
        public virtual decimal TotalPrice { get; set; }
    }
}