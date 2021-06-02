using CRM.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Repositories
{
    public interface IInvoiceRepository
    {
        public Task<InvoiceHeader> GetInvoice(string invoiceNo);
    }

    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly AppDbContext context;

        public InvoiceRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<InvoiceHeader> GetInvoice(string invoiceNo)
        {
            var invoice = await context.InvoiceHeaders
                .Include(x => x.details)
                .Include(x => x.invoiceType)
                .Include(x => x.paymentMethod)
                .FirstOrDefaultAsync(x => x.invoiceNo == invoiceNo);
            
            return invoice;
        }
    }
}
