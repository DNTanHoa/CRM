using CRM.Models;
using CRM.Models.Repositories;
using CRM.RequestModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Validators
{
    public class CustomerRequestModelValidator 
        : AbstractValidator<CustomerCreateOrUpdateRequestModel> 
    {
        private readonly IGenericRepository<CustomerType> genericCustomerStyleRepository;

        public CustomerRequestModelValidator(
            IGenericRepository<CustomerType> genericCustomerStyleRepository)
        {
            this.genericCustomerStyleRepository = genericCustomerStyleRepository;

            RuleFor(x => x.name).NotEmpty().NotNull()
                .WithMessage("Name can't be null");
            RuleFor(x => x.customerTypeCode).NotEmpty().NotNull()
                .WithMessage("Please select customer type");
            RuleFor(x => x.address).NotEmpty().NotNull()
                .WithMessage("Address can't be null");
        }
    }
}
