using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models
{
    public class BaseModel
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
