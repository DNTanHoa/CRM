using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.RequestModel
{
    public class CustomerCreateOrUpdateRequestModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public string taxCode { get; set; }
        public string address { get; set; }
        public string bankAccountName { get; set; }
        public string bankNumber { get; set; }
        public string bankName { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string phone { get; set; }
        public string contactPerson { get; set; }
        public string RepresentPerson { get; set; }
        public string customerTypeCode { get; set; }
        public string identityNumber { get; set; }
        public string identityPlace { get; set; }
        public DateTime? idetityDate { get; set; }
        public DateTime? dateOfBirth { get; set; }
    }
}
