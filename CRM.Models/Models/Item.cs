using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class Item
    {
        public int itemId { get; set; }
        public string itemName { get; set; }
        public ItemCategory category { get; set; }
        public ItemGroup group { get; set; }
        public Unit unit { get; set; }
    }
}
