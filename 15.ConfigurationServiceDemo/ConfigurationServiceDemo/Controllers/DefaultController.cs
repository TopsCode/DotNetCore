using ConfigurationServiceDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationServiceDemo.Controllers
{
    public class DefaultController : Controller
    {
        public IConfiguration Configuration { get; }
        private MyApplicationKeysOptions options;

        public DefaultController(IConfiguration configuration,IOptions<MyApplicationKeysOptions> _options)
        {
            Configuration = configuration;
            options = _options.Value;
        }

        public IActionResult Index()
        {
            ViewBag.LogLevel = Configuration["Logging:LogLevel:Default"];
            ViewBag.SMTPServer = options.SMTPServer;
            ViewBag.AzureSQLServerURL = options.AzureSQLServerURL;
            ViewBag.EmployeePhotoUploadPath = options.EmployeePhotoUploadPath;
            return View();
        }
    }
}
