using Microsoft.AspNetCore.Mvc;
using PartialViewStronglyTypes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewStronglyTypes.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid=1,fname="Jubin",salary=25000 });
            li.Add(new Employee { empid=2,fname="Nishit",salary=39000 });
            li.Add(new Employee { empid=3,fname="Minal",salary=24000 });
            li.Add(new Employee { empid=4,fname="Virang",salary=31000 });
            li.Add(new Employee { empid=5,fname="Mudra",salary= 30000 });

            return View(li);
        }
    }
}
