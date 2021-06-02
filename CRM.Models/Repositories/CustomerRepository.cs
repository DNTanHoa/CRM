using CRM.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Models.Repositories
{
    public interface ICustomerRepository
    {
        public bool IsExistCustomer(string customerCode, out Customer customer);
    }
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;

        public CustomerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool IsExistCustomer(string code, out Customer existCustomer)
        {
            var customer = context.Customer.FirstOrDefault(x => x.code == code);
            if (customer != null)
            {
                existCustomer = customer;
                return true;
            }
            else
            {
                existCustomer = null;
            }
            return false;
        }
    }
}
