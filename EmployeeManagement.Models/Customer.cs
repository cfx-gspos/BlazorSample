using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Customer : BaseModel
    {
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string To { get; set; }
        [DisplayName("Ship To")]
        [Required]
        public string ShipTo { get; set; }
        [DisplayName("Yearly Manday Details")]
        public List<CustomerHistory> CustomerHistories { get; set; }
    }
 
}
