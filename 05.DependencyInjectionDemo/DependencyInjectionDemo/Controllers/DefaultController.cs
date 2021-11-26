using DependencyInjectionDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Controllers
{
    public class DefaultController : Controller
    {        
        private readonly IVisitorCounter _counter;
        public DefaultController(IVisitorCounter counter)
        {
            _counter = counter;
        }

        //public IActionResult Index([FromServices]IVisitorCounter _counter)
        public IActionResult Index()
        {
            //ViewBag.count= obj.GetCount();
            ViewBag.count = _counter.GetCount();
            ViewBag.count = _counter.GetCount();
            ViewBag.count = _counter.GetCount();
            return View();
        }

        public IActionResult Homepage()
        {
            ViewBag.count = _counter.GetCount();
            return View();
        }
    }
}
