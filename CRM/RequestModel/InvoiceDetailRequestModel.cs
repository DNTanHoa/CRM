using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.RequestModel
{
    public class InvoiceDetailRequestModel
    {
        public int id { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public decimal unitPrice { get; set; }
        public string unitCode { get; set; }
        public string unitName { get; set; }
        public decimal quantity { get; set; }
        public decimal total { get; set; }
        public string note { get; set; }
        public string functionCode { get; set; }
        public string functionName { get; set; }
    }
}
