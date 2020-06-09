using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.ComponentModel;

namespace EmployeeManagement.Models
{
    public class Customer : BaseModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string To { get; set; }
        [DisplayName("Ship To")]
        public string ShipTo { get; set; }
        [DisplayName("Yearly Manday Details")]
        public List<CustomerHistory> CustomerHistories { get; set; }
    }
}
