using CRM.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.Extensions
{
    public static class InvoiceExtension
    {
        public static void SetDefaultValue(this InvoiceHeader invoice)
        {
            if(invoice.publishDate == null)
            {
                invoice.publishDate = DateTime.Now;
            }

            if (string.IsNullOrEmpty(invoice.code))
            {
                invoice.code = AppGlobal.DefaultCode;
            }
        }
    }
}
