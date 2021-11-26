using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Default/ShowData",Name = "ListOfProducts")]
        public IActionResult ShowData()
        {
            return View();
        }


        public IActionResult CustomTagHelpers()
        {
            return View();
        }

    }
}
