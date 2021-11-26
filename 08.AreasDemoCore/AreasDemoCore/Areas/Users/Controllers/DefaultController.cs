using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreasDemoCore.Areas.Users.Controllers
{
    [Area("Users")]
    public class DefaultController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
    }
}
