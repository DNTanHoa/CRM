using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.RequestModel
{
    public class InvoiceCreateOrUpdateRequestModel
    {
        public string code { get; set; }
        public string invoiceNo { get; set; }
        public string patern { get; set; }
        public string serial { get; set; }
        public string description { get; set; }

        #region customer
        public string customerCode { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string customerTaxCode { get; set; }
        public string customerPhone { get; set; }
        public string customerBankName { get; set; }
        public string customerBankAccountNumber { get; set; }
        #endregion

        #region seller
        public string sellerName { get; set; }
        public string sellerAddress { get; set; }
        public string sellerTaxCode { get; set; }
        public string sellerPhone { get; set; }
        public string sellerBankName { get; set; }
        public string sellerBankAccountNumber { get; set; }
        #endregion

        public string paymentMethodCode { get; set; }
        public string invoiceTypeCode { get; set; }
        public decimal totalNoTax { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal tax { get; set; }
        public decimal totalTax { get; set; }
        public decimal totalWithTax { get; set; }
        public decimal exChangeRate { get; set; }
        public string currency { get; set; }
        public string currencyInText { get; set; }
        public DateTime? publishDate { get; set; }
        public IEnumerable<InvoiceDetailRequestModel> details { get; set; }
    }
}
