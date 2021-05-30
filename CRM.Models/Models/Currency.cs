using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class Currency : BaseModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public bool getExchange { get; set; }
    }
}
