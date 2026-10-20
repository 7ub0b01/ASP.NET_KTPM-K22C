using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    public class Component_Todo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
