using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxDemoCore.Models;

namespace AjaxDemoCore.Controllers
{
    public class DefaultController : Controller
    {
        private CompanyContext dc = null;
        public DefaultController(CompanyContext db)
        {
            this.dc = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployees()
        {
            //dc.Configuration.ProxyCreationEnabled = false;
            return Json(dc.Tblemployees.ToList());
        }
        public IActionResult AddEmp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmp(Tblemployee obj)
        {
            dc.Tblemployees.Add(obj);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
