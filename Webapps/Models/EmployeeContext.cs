using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webapps.Models
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Department> departments { get; set; }
    }
}