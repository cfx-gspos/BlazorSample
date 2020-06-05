using BlazorServer.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }
   }
}
