using System;
using Microsoft.AspNetCore.Mvc;
using OrderWebApp.Models;
using System.Collections.Generic;

namespace OrderWebApp.Controllers
{
    public class OrderListController : Controller
    {
        private List<Order> m_OrderList;
        public OrderListController()
        {
            m_OrderList = new List<Order>()
            {
                new Order()
                {
                    SenderAddress = "asdasd",
                    SenderCity = "dfsdfsfd",
                    RecipientAddress = "dfgdfgdfgdfg",
                    RecipientCity = "dfgdfdfgdfg",
                    PackageWeightInkilograms = 10,
                    PackagePickUpDate = DateTime.Now
                }
            };
        }

        public IActionResult Index()
        {
            return View(m_OrderList);
        }
    }
}
