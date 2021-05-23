using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrderWebApp.Models;
using OrderWebApp.ViewModels;

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

            List<OrderViewModel> orderViewModelList = new List<OrderViewModel>(orderList.Count);

            foreach(Order order in orderList)
            {
                orderViewModelList.Add(new OrderViewModel(order));
            }

            return View(orderViewModelList);
        }
    }
}
