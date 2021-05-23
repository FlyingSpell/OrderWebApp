using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrderWebApp.Models;

namespace OrderWebApp.Controllers
{
    public class OrderListController : Controller
    {
        private ModelsDbContext m_ModelsDbContext;
        public OrderListController(ModelsDbContext context)
        {
            m_ModelsDbContext = context;
        }

        public IActionResult Index()
        {
            List<Order> orderList = m_ModelsDbContext.Orders.ToList();
            orderList.Reverse();

            return View(orderList);
        }
    }
}
