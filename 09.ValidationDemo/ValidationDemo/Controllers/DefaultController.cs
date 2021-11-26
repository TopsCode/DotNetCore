using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult JsValidation()
        {
            return View();
        }

        public IActionResult bValidator()
        {
            return View();
        }

        public IActionResult DataAnnotation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DataAnnotation(Employee obj)
        {
            if (ModelState.IsValid)
            {
                return Content("Success.");
            }
            return View();
        }
    }
}
