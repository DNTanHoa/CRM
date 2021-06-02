using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class AccountingPeriod : BaseModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public string fiscalYear { get; set; }
        public DateTime startDate { get; set; }
        public DateTime dateLocked { get; set; }
        public bool isClosed { get; set; }
    }
}
