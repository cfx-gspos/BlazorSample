using BlazorServer.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public partial class EditEmployee
    {
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDepartmentServce DepartmentServce { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
        public string DepartmentId { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            Departments = (await DepartmentServce.GetDepartments()).ToList();
            DepartmentId = Employee.DepartmentId.ToString();
        }
    }
}
