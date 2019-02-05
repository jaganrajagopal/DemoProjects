using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Webapps.Models
{
    [Table("employeeList")]
    public class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public int phoneNumber { get; set; }
    }
}