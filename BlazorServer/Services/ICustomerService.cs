using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomers();
    }
}
