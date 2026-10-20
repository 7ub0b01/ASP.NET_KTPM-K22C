using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    public class HelloController : Controller
    {
        public string Greeting()
        {
            return "Chao mung cac ban den voi ASP.NET";
        }

        public string Welcome(int id1, string name)
        {
            return $"Xin chao {id1} - {name}, chuc cac ban hoc tot";
        }

        //IactionResult
        public IActionResult Welcome1(int numTimes, string name)
        {
            ViewBag.Id = numTimes;
            ViewData["Name"] = name;
            //ViewData["Message"] = $"Xin chao {id1} - {name}, chuc cac ban hoc tot";

            return View();
        }
    }
}
