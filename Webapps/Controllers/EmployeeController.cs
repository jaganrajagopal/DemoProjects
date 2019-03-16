using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webapps.Models;

namespace Webapps.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeDbEntitiesRecent dbEntitles = new EmployeeDbEntitiesRecent();
        
        public ActionResult Index()
        {
            return View(dbEntitles.employeeLists.ToList());
        }
        [ActionName("Details")]
        public ActionResult EmployeeDetails(int id)
        {
           

            
           var employee= dbEntitles.employeeLists.Single(data => data.empId == id);
            return View(employee);
        }

        public ActionResult DepartmentDetails(int id)
        {
            //EmployeeContext dbcontext = new EmployeeContext();
            //Department departments = dbcontext.departments.Single(data => data.departmentId == id);
            //departmentlist mydepartment = new departmentlist();
            //mydepartment.

            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection frm)
        {
            departmentList empList = new departmentList();
            empList.deptId =int.Parse( frm["deptid"]);
            empList.departmentName = frm["departmentName"];
            empList.empId = int.Parse(frm["empid"]);
            if (ModelState.IsValid)
            {
                dbEntitles.departmentLists.Add(empList);
                dbEntitles.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}