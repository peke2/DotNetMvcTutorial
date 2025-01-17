using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // public string Index()
        // {
        //     return "This is my default action...";
        // }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WelCome(string name, int numTimes=1)
        {
            ViewData["Message"] = "Hello" +  name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}