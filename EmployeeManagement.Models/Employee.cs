using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "写名字")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }

        public Department Department { get; set; }
    }
}
