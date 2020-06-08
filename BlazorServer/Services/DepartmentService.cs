using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorServer.Services
{
    public class DepartmentService : IDepartmentServce
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Department> GetDepartment(int id)
        {
            return await httpClient.GetJsonAsync<Department>($"api/department/{id}");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await httpClient.GetJsonAsync<Department[]>($"api/department");
        }
    }
}
