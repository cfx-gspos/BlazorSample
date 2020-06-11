using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorServer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient httpClient;

        public CustomerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Customer> GetCustomer(string id)
        {
            return await httpClient.GetJsonAsync<Customer>($@"/api/customer/{id}");
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await httpClient.GetJsonAsync<IEnumerable<Customer>>("/api/customer");
        }

        public async Task<bool> SaveCustomer(Customer customer)
        {
            return await httpClient.PutJsonAsync<bool>("/api/customer/SaveCustomer", customer);
        }
    }
}
