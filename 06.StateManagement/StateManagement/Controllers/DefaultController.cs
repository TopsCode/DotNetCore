using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagement.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DefaultController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        //1. Cookies
        public IActionResult Index()
        {
            //_httpContextAccessor.HttpContext.Response.Cookies.Delete("username");

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(2);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("username","Ankit");

            return View();
        }
        public IActionResult ReadCookieData()
        {
            return View();
        }

        //Query string
        public IActionResult QueryStringDemo(string msg="Default message")
        {
            ViewBag.msg = msg;
            return View();
        }

        // session object
        public IActionResult SessionObject()
        {
            _httpContextAccessor.HttpContext.Session.SetString("Myusername","ankit");
            //ViewBag.sessionid = _httpContextAccessor.HttpContext.Session.Id;
            return View();
        }

        public IActionResult ShowSessionData()
        {           
            return View();
        }

        public IActionResult ViewBagData()
        {
            ViewData["Ecode"] = 101;
            ViewData["Ename"] = "Ankit";

            ViewBag.Message = "This is coming from ViewBag.Message";

            //Cookie TempData Provider
            TempData.Add("Country","India");



            return View();
        }

        [HttpPost]
        public IActionResult ViewBagData(IFormCollection fc)
        {            
            return View();
        }


    }
}
