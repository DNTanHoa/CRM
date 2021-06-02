using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class PaymentTerm : BaseModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
