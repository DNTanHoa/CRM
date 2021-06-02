using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class UnitConvert
    {
        public Item item { get; set; }
        public Unit destinationUnit { get; set; }
        public decimal coefficient { get; set; }
        public bool inUse { get; set; }
    }
}
