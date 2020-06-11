using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Model
{
    public interface ICustomerRepository
    {
          Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomer(string id);
        Task<bool> SaveCustomer(Customer customer);

    }
}
