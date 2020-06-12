using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Api.Model;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await customerRepository.GetCustomers();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<Customer> GetCustomer(string id)
        {
            return await customerRepository.GetCustomer(id);
        }

        [HttpPut]
        [Route("{SaveCustomer}")]
        public async Task<bool> SaveCustomer(Customer customer)
        {
            return await customerRepository.SaveCustomer(customer);
        }
        [HttpPost]
        [Route("{delete}")]
        public async Task<bool> DeleteCustomer(string id)
        {
            return await customerRepository.DeleteCustomer(id);
        }
    }
}
