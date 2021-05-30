using AutoMapper;
using CRM.Models;
using CRM.SharedModels.Atuhenticate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Mapper
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, AuthenticateUser>();
        }
    }
}
