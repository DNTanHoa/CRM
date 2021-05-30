using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class Company : BaseModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public string taxCode { get; set; }
        public string displayTaxCode { get; set; }
        public string logo { get; set; }
        public string phone { get; set; }
        public string displayPhone { get; set; }
        public string email { get; set; }
        public string displyEmail { get; set; }
        public string faxNumber { get; set; }
        public string displayFaxNumber { get; set; }
        public string website { get; set; }
        public string representPerson { get; set; }
        public string representPosition { get; set; }
        public string contactPerson { get; set; }
        public string contactPosition { get; set; }
        public string address { get; set; }
        public string displayAddress { get; set; }
        public string note { get; set; }
    }
}
