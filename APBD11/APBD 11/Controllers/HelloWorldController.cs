using Microsoft.AspNetCore.Mvc;

namespace APBD_11.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Text.Encodings.Web;
}

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}