using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
    }
}
