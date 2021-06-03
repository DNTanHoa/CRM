using AutoMapper;
using CRM.Models;
using CRM.Models.Contexts;
using CRM.Models.Extensions;
using CRM.Models.Repositories;
using CRM.RequestModel;
using CRM.SharedModels.Common;
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
    public class InvoiceController : ControllerBase
    {
        private readonly IGenericRepository<InvoiceHeader> genericInvoiceHeaderRepository;
        private readonly IGenericRepository<InvoiceDetail> genericInvoiceDetailRepository;
        private readonly IInvoiceRepository invoiceRepository;
        private readonly IMapper mapper;
        private readonly AppDbContext context;

        public InvoiceController(IGenericRepository<InvoiceHeader> genericInvoiceHeaderRepository,
            IGenericRepository<InvoiceDetail> genericInvoiceDetailRepository,
            IInvoiceRepository invoiceRepository,
            IMapper mapper,
            AppDbContext context)
        {
            this.genericInvoiceHeaderRepository = genericInvoiceHeaderRepository;
            this.genericInvoiceDetailRepository = genericInvoiceDetailRepository;
            this.invoiceRepository = invoiceRepository;
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public ActionResult<CommonApiResponeModel> GetInvoiceHeaders()
        {
            var data = genericInvoiceHeaderRepository.Get();
            return new CommonApiResponeModel()
                .SetData(data)
                .SetResult(new CommonApiResult()
                {
                    message = "success",
                    messageCode = "success"
                });
        }

        [HttpGet]
        public ActionResult<CommonApiResponeModel> GetInvoiceHeader(string invoiceCode)
        {
            var invoiceHeader = genericInvoiceHeaderRepository.GetByID(invoiceCode);
            if(invoiceHeader != null)
            {
                return new CommonApiResponeModel()
                    .SetData(invoiceHeader)
                    .SetResult(new CommonApiResult()
                    {
                        message = "success",
                        messageCode = "success"
                    });
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<ActionResult<CommonApiResponeModel>> GetInvoice(string invoiceNo)
        {
            if (string.IsNullOrEmpty(invoiceNo))
                return BadRequest();

            var invoice = await invoiceRepository.GetInvoice(invoiceNo);

            if(invoice != null)
            {
                return new CommonApiResponeModel()
                    .SetData(invoice)
                    .SetResult(new CommonApiResult()
                    {
                        message = "success",
                        messageCode = "OK"
                    });
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<CommonApiResponeModel>> CreateInvoice(
            InvoiceCreateOrUpdateRequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var invoiceHeader = mapper.Map<InvoiceHeader>(requestModel);

                invoiceHeader.SetDefaultValue();
                
                foreach(var line in requestModel.details)
                {
                    var invoiceDetail = mapper.Map<InvoiceDetail>(line);

                    invoiceDetail.header = invoiceHeader;
                }

                genericInvoiceHeaderRepository.Insert(invoiceHeader);
                
                var result = context.SaveChanges();

                if (result > 0)
                {
                    return new CommonApiResponeModel()
                    .SetResult(new CommonApiResult()
                    {
                        messageCode = "success",
                        message = "Create invoice successfully"
                    })
                    .SetData(invoiceHeader);
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
            return BadRequest();
        }
    }
}
