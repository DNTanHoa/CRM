using AutoMapper;
using CRM.Models;
using CRM.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Mapper
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<CustomerCreateOrUpdateRequestModel, Customer>();
        }
    }
}
