using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class Invoice : IEntity
    {
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int AddressId { get; set; }
        public string CargoFicheNo { get; set; }
        public decimal TotalPrice { get; set; }
    }
}