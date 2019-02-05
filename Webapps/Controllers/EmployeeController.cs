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
        EmployeeDbEntities dbEntitles = new EmployeeDbEntities();
        public ActionResult Index()
        {
            return View(dbEntitles.employeeLists.ToList());
        }

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
            departmentlist empList = new departmentlist();
            empList.deptid =int.Parse( frm["deptid"]);
            empList.departmentName = frm["departmentName"];
            empList.empid = frm["empid"];
            if (ModelState.IsValid)
            {
                dbEntitles.departmentlists.Add(empList);
                dbEntitles.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}