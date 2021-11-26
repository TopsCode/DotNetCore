using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("f_name,email")]Employee obj)
        {
            return View();
        }
    }
}
