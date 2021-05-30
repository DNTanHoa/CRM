using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.SharedModels.Atuhenticate
{
    public class AuthenticateUser
    {
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string token { get; set; }
    }
}
