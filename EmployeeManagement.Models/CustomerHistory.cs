using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EmployeeManagement.Models
{
    public class CustomerHistory : BaseModel
    {
        public string ID { get; set; }
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
        [DisplayName("Yearly Man Day Cost")]
        public double YearlyManDayCost { get; set; }
        [DisplayName("Yearly Man Day Discounted Cost")]
        public double YearlyManDayDiscountedCost { get; set; }
        public string CustomerID { get; set; }
    }
}
