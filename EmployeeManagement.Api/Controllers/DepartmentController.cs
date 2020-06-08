using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetDepartments()
        {
            try
            {
                return Ok(await departmentRepository.GetDepartments());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> GetDepartment(int id)
        {
            try
            {
                return Ok(await departmentRepository.GetDepartment(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
