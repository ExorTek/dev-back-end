using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class Payment : IEntity
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public byte PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsOk { get; set; }
        public string ApproveCode { get; set; }
        public decimal PaymentTotal { get; set; }
    }
}