using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class InvoiceDetail : BaseModel
    {
        public int id { get; set; }
        public InvoiceHeader header { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public decimal unitPrice { get; set; }
        public Unit unit { get; set; }
        public decimal quantity { get; set; }
        public decimal total { get; set; }
        public string note { get; set; }
        public InvoiceDetailFunction function { get; set; }
    }
}
