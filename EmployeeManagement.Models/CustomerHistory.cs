using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models
{
    public class CustomerHistory : BaseModel
    {
        public string ID { get; set; }
        [DisplayName("Start Date")]
        [Required]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        [Required]
        public DateTime EndDate { get; set; }
        [DisplayName("Yearly Man Day Cost")]
        [Required]
        public double YearlyManDayCost { get; set; }
        [DisplayName("Yearly Man Day Discounted Cost")]
        [Required]
        public double YearlyManDayDiscountedCost { get; set; }
        public string CustomerID { get; set; }
    }
}
