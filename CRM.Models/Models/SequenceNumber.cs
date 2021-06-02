using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class SequenceNumber : BaseModel
    {
        public int id { get; set; }
        public string prefix { get; set; }
        public string subfix { get; set; }
        public string partern { get; set; }
        public string serial { get; set; }
        public string numberFrom { get; set; }
        public string numberTo { get; set; }
        public string lastNumber { get; set; }
    }
}
