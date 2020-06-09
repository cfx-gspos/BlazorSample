using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models
{
    public class CustomerHistory : BaseModel
    {
        public string ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double YearlyManDayCost { get; set; }
        public double YearlyManDayDiscountedCost { get; set; }
        public string CustomerID { get; set; }
    }
}
