using Microsoft.AspNetCore.Mvc;

namespace OrderWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
