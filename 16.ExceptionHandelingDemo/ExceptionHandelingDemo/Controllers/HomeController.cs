using ExceptionHandelingDemo.Filters;
using ExceptionHandelingDemo.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionHandelingDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [MyCustomExceptionFilter]
        public IActionResult Index()
        {
            ////1.
            int a, b, c;
            a = 90;
            b = 0;
            c = a / b;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

            //// 2. Only called in production environment (launchSettings.json->"profiles"->"ASPNETCORE_ENVIRONMENT": "Production")
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            return View(exceptionHandlerPathFeature.Error);
        }
    }
}
