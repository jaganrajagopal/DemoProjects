using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace Webapps.Models
{
    [TableName("departmentList")]
    public class Department { 

        [Key]
        public int departmentId { get; set; }

        public string departmentName { get; set; }
    }
}