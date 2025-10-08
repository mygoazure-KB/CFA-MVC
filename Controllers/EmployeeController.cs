using CFACrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace CFACrud.Controllers
{
    public class EmployeeController : Controller
    {
        EmpDbContext obj = new EmpDbContext();
        public ActionResult Index()
        {
            return View(obj.Employees.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Employee emp)
        {
            obj.Employees.Add(emp);
            obj.SaveChanges();
            return RedirectToAction("Index","Employee");
        }
    }
}