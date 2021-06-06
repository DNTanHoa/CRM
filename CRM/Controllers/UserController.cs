using AutoMapper;
using CRM.Models;
using CRM.Models.Repositories;
using CRM.RequestModel;
using CRM.SharedModels.Atuhenticate;
using CRM.SharedModels.Common;
using CRM.SharedUltilities.Extensions;
using CRM.SharedUltilities.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IGenericRepository<User> genericUserRepository;
        private readonly IMapper mapper;

        public UserController(IGenericRepository<User> genericUserRepository,
            IMapper mapper)
        {
            this.genericUserRepository = genericUserRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<CommonApiResponeModel> Authenticate(AuthenticateRequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var user = genericUserRepository.GetByID(requestModel.username);
                if (user != null)
                {
                    if (SecurityHelpers.Encrypt(user.hashKey, requestModel.password) == user.password)
                    {
                        var authenticatedUser = new AuthenticateUser();
                        authenticatedUser = mapper.Map<AuthenticateUser>(user);

                        authenticatedUser.token = ClaimHelpers.GenerateTokenStringForClaims(user.ToDictionaryStringString());

                        return new CommonApiResponeModel()
                            .SetResult(new CommonApiResult()
                            {
                                messageCode = "200",
                                message = "Success"
                            })
                            .SetData(authenticatedUser);
                    }
                    else
                    {
                        return new CommonApiResponeModel()
                            .SetResult(new CommonApiResult()
                            {
                                messageCode = "403",
                                message = "Invalid password"
                            });
                    }
                }
                else
                {
                    return new CommonApiResponeModel()
                    .SetResult(new CommonApiResult()
                    {
                        messageCode = "403",
                        message = "Username does not exist!"
                    });
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
