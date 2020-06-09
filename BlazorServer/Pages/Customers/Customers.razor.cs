using BlazorServer.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages.Customers
{
    public partial class Customers : ComponentBase
    {
        [Inject]
        private ICustomerService CustomerService { get; set; }
        IEnumerable<Customer> CustomerList { get; set; } = null;
        protected async override Task OnInitializedAsync()
        {
            CustomerList = await CustomerService.GetCustomers();
        }
    }
}
