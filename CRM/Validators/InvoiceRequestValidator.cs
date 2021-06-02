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

        }
    }
}
