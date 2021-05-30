using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class User 
    {
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string avatar { get; set; }
        public string hashKey { get; set; }
        public bool active { get; set; }
    }
}
