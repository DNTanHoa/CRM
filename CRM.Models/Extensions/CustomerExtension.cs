using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.Extensions
{
    public static class CustomerExtension
    {
        public static void SetDefaultValue(this Customer customer)
        {
            if (string.IsNullOrEmpty(customer.code))
            {
                customer.code = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            }
        }
    }
}
