using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Model
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await appDbContext.Customers.Include(c => c.CustomerHistories).ToListAsync();
        }
    }
}
