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

        public async Task<bool> DeleteCustomer(string id)
        {
            var customer = await appDbContext.Customers.FirstOrDefaultAsync(x => x.ID == id);
            customer.IsDeleted = true;
            var customerHistories = await appDbContext.CustomerHistories.Where(x => x.CustomerID == id).ToListAsync();
            foreach (var customerHistory in customerHistories)
            {
                customerHistory.IsDeleted = true;
            }
            appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Customer> GetCustomer(string id)
        {
            return await appDbContext.Customers.Include(c => c.CustomerHistories).FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await appDbContext.Customers.Include(c => c.CustomerHistories).Where(x=>!x.IsDeleted).ToListAsync();
        }

        public async Task<bool> SaveCustomer(Customer customer)
        {
            if (customer.ID != null)
            {
                //Update Customer
                var oldCustomer = appDbContext.Customers.FirstOrDefault(x => x.ID == customer.ID);
                oldCustomer.Name = customer.Name;
                oldCustomer.To = customer.To;
                oldCustomer.ShipTo = customer.ShipTo;
            }
            else
            {
                customer.ID = Guid.NewGuid().ToString();
                appDbContext.Customers.Add(customer);
            }

            //update Customer History.
            appDbContext.CustomerHistories.RemoveRange(appDbContext.CustomerHistories.Where(x => x.CustomerID == customer.ID).ToList());
            foreach (var customerHistory in customer.CustomerHistories)
            {
                appDbContext.CustomerHistories.Add(customerHistory);

            }

            appDbContext.SaveChanges();
            return true;
        }
    }
}
