using CRM.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Models.Repositories
{
    public interface ICustomerTypeRepository
    {
        public bool IsExistCustomerType(string code, out CustomerType existType);
    }
    public class CustomerTypeRepository : ICustomerTypeRepository
    {
        private readonly AppDbContext context;

        public CustomerTypeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool IsExistCustomerType(string code, out CustomerType existType)
        {
            var customerType = context.CustomerType.FirstOrDefault(x => x.code == code);
            if (customerType != null)
            {
                existType = customerType;
                return true;
            }
            else 
            {
                existType = null;
            }
            return false;
        }
    }
}
