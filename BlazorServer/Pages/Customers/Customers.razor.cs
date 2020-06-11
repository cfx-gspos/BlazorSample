using BlazorServer.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AntDesign;
namespace BlazorServer.Pages.Customers
{
    public partial class Customers : ComponentBase
    {
        protected bool editModalVisible { get; set; } = false;
        protected Customer EditCustomer { get; set; }
        [Inject]

        private ICustomerService CustomerService { get; set; }
        [Inject]
        private MessageService messageService { get; set; }

        IEnumerable<Customer> CustomerList { get; set; } = new List<Customer>();
        protected async override Task OnInitializedAsync()
        {
            EditCustomer = new Customer { };
            CustomerList = await CustomerService.GetCustomers();
        }

        protected async void BindCustomer(string id)
        {
            if (id != null)
            {
                EditCustomer = await CustomerService.GetCustomer(id);
            }
            else
            {
                EditCustomer = new Customer { ID = null };
                EditCustomer.CustomerHistories = new List<CustomerHistory>();
            }

            StateHasChanged();
        }
        protected void AddYearlyManday()
        {
            EditCustomer.CustomerHistories.Add(new CustomerHistory { ID = Guid.NewGuid().ToString(), CustomerID = EditCustomer.ID });
        }
        protected void DeleteYearlyManday(string id)
        {
            EditCustomer.CustomerHistories.Remove(EditCustomer.CustomerHistories.FirstOrDefault(x => x.ID == id));
        }
        protected async void SaveCustomer()
        {
            var result = await CustomerService.SaveCustomer(EditCustomer);
            CustomerList = await CustomerService.GetCustomers();
            editModalVisible = false;
            StateHasChanged();
            messageService.Success("Save customer successfully!");
        }
        async Task PageIndexChanged(PaginationEventArgs args)
        {

        }
    }
}
