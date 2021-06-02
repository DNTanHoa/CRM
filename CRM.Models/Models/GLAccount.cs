using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class GLAccount : BaseModel
    {
        public string code { get; set; }
        public string name { get; set; }
        GLCategory category { get; set; }
        public decimal netChange { get; set; }
        public decimal creditAmount { get; set; }
        public decimal debitAmount { get; set; }
        public bool isCredit { get; set; }
        public bool isDebit { get; set; }
    }
}
