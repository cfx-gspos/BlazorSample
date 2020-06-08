using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Services
{
    public interface IDepartmentServce
    {
          Task<IEnumerable<Department>> GetDepartments();
          Task<Department> GetDepartment(int id);
    }
}
