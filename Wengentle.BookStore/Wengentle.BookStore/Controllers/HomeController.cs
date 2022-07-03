using Microsoft.AspNetCore.Mvc;

namespace Webgentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //var obj = new { id = 1, Name= "piyush"};
            //return type 1: View();
            //return type 2: View(obj);
            //return type 3: View("AboutUs");
            //return type 4: View("AboutUs",obj);
            //return View("TempView/tempViewFromDifferentLocation.cshtml");
            //return View("../../TempView/tempViewFromDifferentLocation");

            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
