using CRM.RequestModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Validators
{
    public class InvoiceRequestValidator : 
        AbstractValidator<InvoiceCreateOrUpdateRequestModel> 
    {
        public InvoiceRequestValidator()
        {
            RuleFor(x => x.customerCode)
                .NotNull().NotEmpty().WithMessage("Customer code can't be null");
            RuleFor(x => x.customerName)
                .NotNull().NotEmpty().WithMessage("Customer name can't be null");
            RuleFor(x => x.customerAddress)
                .NotNull().NotEmpty().WithMessage("Customer address can't be null");
            RuleFor(x => x.sellerName)
                .NotNull().NotEmpty().WithMessage("Seller name can't be null");
            RuleFor(x => x.sellerAddress)
                .NotNull().NotEmpty().WithMessage("Seller address can't be null");
            RuleFor(x => x.paymentMethodCode)
                .NotNull().NotEmpty().WithMessage("Payment method can't be null");
            RuleFor(x => x.invoiceTypeCode)
                .NotNull().NotEmpty().WithMessage("Invoice type address can't be null");
        }
    }
}
