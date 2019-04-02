using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //================ Interface ================

        public IActionResult Index()
        {
            //Call to view Views/HelloWorld/Index.cshtml
            return View();
        }

        // GET: /HelloWorld/Welcome?name=tuan&numTimes=2

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //Binding data to view Views/HelloWorld/Welcome.cshtml
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }


        //================ Interface ================


        // 
        // GET: /HelloWorld/

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // GET: /HelloWorld/Welcome?name=tuan&numTimes=2
        // Requires using System.Text.Encodings.Web;

        public string Welcome1(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        // GET: /HelloWorld/Welcome/2?name=tuan

        public string Welcome2(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}