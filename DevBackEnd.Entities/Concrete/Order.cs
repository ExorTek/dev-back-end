using DevBackEnd.Core.Entities;
using System;

namespace DevBackEnd.Entities.Concrete
{
    public class Order : IEntity
    {
        public virtual int OrderId { get; set; }
        public virtual int UserId { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual decimal TotalPrice { get; set; }
        public virtual byte Status { get; set; }
        public virtual int AddressId { get; set; }
    }
}