using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Text;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Http;

namespace ReturnTypesOfActionsDemo.Controllers
{
    public class DefaultController : Controller
    {
        // provide info about the web hosting environment of current application.
        private readonly IWebHostEnvironment _environment;

        public DefaultController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        //1
        public ContentResult GreetUser()
        {
            //display string content on browser. We can also write html & XML content.

            //return Content("Hello World from .Net Core MVC");
            //return Content("<div><b>Hello World from .Net Core MVC</b></div>","text/html");
            //return Content("<div><b>Hello World from .Net Core MVC</b></div>","text/xml");

            //returns the path of directory where the current project files are stored.
            //return Content(_environment.ContentRootPath);

            //returns the path of the wwwroot folder
            return Content(_environment.WebRootPath);
        }
        //2
        public ViewResult showMessage(string message = "Default Message")
        {
            ViewBag.message = message;
            return View();
        }

        //3.use fiddler for status code
        public RedirectResult GotoURL()
        {
            // with HTTP status code : 302.
            return Redirect("http://www.google.com");
        }
        public RedirectResult GotoURLPermanently()
        {
            // with HTTP status code : 301.
            return RedirectPermanent("http://www.google.com");
        }

        //4.redirect to another action
        public RedirectToActionResult GotoAnotherAction()
        {
            // with HTTP status code : 302.
            return RedirectToAction("showMessage", new { message = "I am coming from different action.." });
        }

        //5. new Route in Startup.cs
        public RedirectToRouteResult GotoAbout()
        {
            // this will redirect using the endpoints in startup.cs
            return RedirectToRoute("showMessage");
        }

        //6. Download a file with a different name (renaming at the time of download)
        public FileResult DownloadFile()
        {
            return File("/css/site.css", "text/plain", "newsite.css");
        }
        public FileResult DownloadImg()
        {
            return File("./Images/logo.png", "images/png");
        }

        //7. show content of file on browser text or XML or any
        // writes contents to browser
        public FileContentResult DownloadContent()
        {
            var myfile = System.IO.File.ReadAllBytes("./wwwroot/css/site.css");
            return new FileContentResult(myfile, "text/plain");
        }

        //8. used for writing a file from a stream to the response.
        public FileStreamResult CreateFile()
        {
            var stream = new MemoryStream(Encoding.ASCII.GetBytes("Hello World"));
            return new FileStreamResult(stream, new MediaTypeHeaderValue("text/plain"))
            {
                FileDownloadName = "text.txt"
            };
        }

        //9. Return BadRequest Demo
        public BadRequestResult BRRDemo()
        {
            return BadRequest();
        }

        public StatusCodeResult BRStatusCodeDemo()
        {
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        //10. use this when u do not want to allow user to access this part.
        public UnauthorizedResult UnauthorizedResultDemo()
        {
            return Unauthorized();
        }
        public UnauthorizedObjectResult UnauthorizedObjectResultDemo()
        {
            var modelstate = new ModelStateDictionary();
            modelstate.AddModelError("br","You are unauthorized to access this area.");
            return Unauthorized(modelstate);
        }



    }
}
