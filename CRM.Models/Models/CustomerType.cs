﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class CustomerType : BaseModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public string note { get; set; }
    }
}
