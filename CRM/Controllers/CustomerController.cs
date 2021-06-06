using AutoMapper;
using CRM.Models;
using CRM.Models.Contexts;
using CRM.Models.Extensions;
using CRM.Models.Repositories;
using CRM.RequestModel;
using CRM.SharedModels.Common;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly IGenericRepository<Customer> genericCustomerRepository;
        private readonly ICustomerTypeRepository customerTypeRepository;
        private readonly IMapper mapper;
        private readonly IValidator<CustomerCreateOrUpdateRequestModel> requestValidator;
        private readonly ICustomerRepository customerRepository;
        private readonly AppDbContext context;

        public CustomerController(IGenericRepository<Customer> genericCustomerRepository,
            ICustomerTypeRepository customerTypeRepository,
            IMapper mapper,
            IValidator<CustomerCreateOrUpdateRequestModel> requestValidator,
            ICustomerRepository customerRepository,
            AppDbContext context)
        {
            this.genericCustomerRepository = genericCustomerRepository;
            this.customerTypeRepository = customerTypeRepository;
            this.mapper = mapper;
            this.requestValidator = requestValidator;
            this.customerRepository = customerRepository;
            this.context = context;
        }

        [HttpGet]
        public ActionResult<CommonApiResponeModel> GetCustomers()
        {
            var customers = genericCustomerRepository.Get();
            return new CommonApiResponeModel()
                .SetResult(new CommonApiResult()
                {
                    messageCode = "N/A",
                    message = "Nothing"
                })
                .SetData(customers);
        }

        [HttpGet]
        public ActionResult<CommonApiResponeModel> GetCustomer(string code)
        {
            var customer = genericCustomerRepository.GetByID(code);
            if(customer != null)
            {
                return new CommonApiResponeModel()
                .SetResult(new CommonApiResult()
                {
                    messageCode = "success",
                    message = "Get customer"
                })
                .SetData(customer);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<CommonApiResponeModel> CreateCustomer(
            CustomerCreateOrUpdateRequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                if(customerTypeRepository.IsExistCustomerType(requestModel.customerTypeCode,
                    out CustomerType customerType))
                {
                    var customer = mapper.Map<Customer>(requestModel);

                    customer.customerType = customerType;
                    customer.SetDefaultValue();

                    genericCustomerRepository.Insert(customer);
                    var result = context.SaveChanges();
                    
                    if(result > 0)
                    {
                        return new CommonApiResponeModel()
                        .SetResult(new CommonApiResult()
                        {
                            messageCode = "success",
                            message = "Create customer successfully"
                        })
                        .SetData(customer);
                    }
                    else
                    {
                        return new CommonApiResponeModel()
                        .SetResult(new CommonApiResult()
                        {
                            messageCode = "error",
                            message = "Create failed"
                        });
                    }
                }
                else
                {
                    return new CommonApiResponeModel()
                        .SetResult(new CommonApiResult()
                        {
                            messageCode = "error",
                            message = "Invalid customer type"
                        });
                }
            }
            return BadRequest();
        }

        [HttpPut]
        public ActionResult<CommonApiResponeModel> UpdateCustomer(string customerCode,
            CustomerCreateOrUpdateRequestModel requestModel)
        {
            if(string.IsNullOrEmpty(requestModel.code) ||
               requestModel.code != customerCode)
            {
                return BadRequest();
            }
            else if (!customerRepository.IsExistCustomer(customerCode, 
                out Customer exisCustomer))
            {
                return NotFound();
            }
            else
            {
                if(ModelState.IsValid)
                {
                    if (customerTypeRepository.IsExistCustomerType(requestModel.customerTypeCode,
                        out CustomerType customerType))
                    {
                        var customer = mapper.Map<Customer>(requestModel);

                        customer.customerType = customerType;
                        genericCustomerRepository.Update(customer);

                        var result = context.SaveChanges();

                        if (result > 0)
                        {
                            return new CommonApiResponeModel()
                            .SetResult(new CommonApiResult()
                            {
                                messageCode = "success",
                                message = "Update customer successfully"
                            })
                            .SetData(customer);
                        }
                        else
                        {
                            return new CommonApiResponeModel()
                            .SetResult(new CommonApiResult()
                            {
                                messageCode = "error",
                                message = "Update failed"
                            });
                        }
                    }
                    else
                    {
                        return new CommonApiResponeModel()
                            .SetResult(new CommonApiResult()
                            {
                                messageCode = "error",
                                message = "Invalid customer type"
                            });
                    }
                }
            }
            return BadRequest();
        }

        [HttpDelete]
        public ActionResult<CommonApiResponeModel> DeleteCustomer(string customerCode)
        {
            var customer = genericCustomerRepository.GetByID(customerCode);
            if (customer == null)
            {
                return NotFound();
            }

            genericCustomerRepository.Delete(customerCode);
            
            var result = context.SaveChanges();
            if(result > 0)
            {
                return new CommonApiResponeModel()
                        .SetResult(new CommonApiResult()
                        {
                            messageCode = "success",
                            message = "Delete customer successfully"
                        });
            }
            return NotFound();
        }
    }
}
