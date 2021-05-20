using Microsoft.AspNetCore.Mvc;

namespace OrderWebApp.Controllers
{
    public class OrderListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
