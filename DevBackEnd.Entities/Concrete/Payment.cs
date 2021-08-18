using DevBackEnd.Core.Entities;
using System;

namespace DevBackEnd.Entities.Concrete
{
    public class Payment : IEntity
    {
        public virtual int PaymentId { get; set; }
        public virtual int OrderId { get; set; }
        public virtual byte PaymentType { get; set; }
        public virtual DateTime PaymentDate { get; set; }
        public virtual bool IsOk { get; set; }
        public virtual string ApproveCode { get; set; }
        public virtual decimal PaymentTotal { get; set; }
    }
}