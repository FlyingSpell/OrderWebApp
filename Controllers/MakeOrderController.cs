using System;
using Microsoft.AspNetCore.Mvc;
using OrderWebApp.Models;
using OrderWebApp.Services;

namespace OrderWebApp.Controllers
{
    [Route("[controller]")]
    public class MakeOrderController : Controller
    {
        private ModelsDbContext        m_ModelsDbContext;
        private IIdGenerator           m_IdGenerator;
        private IOrderNumberGenerator  m_OrderNumberGenerator;
        private OrderHelperInfoService m_OrderHelperInfoService;
        public MakeOrderController(ModelsDbContext modelsDbContext,
                                   IIdGenerator idGenerator,
                                   IOrderNumberGenerator orderNumberGenerator,
                                   OrderHelperInfoService orderHelperInfoService)
        {
            m_ModelsDbContext = modelsDbContext;
            m_IdGenerator = idGenerator;
            m_OrderNumberGenerator = orderNumberGenerator;
            m_OrderHelperInfoService = orderHelperInfoService;
        }

        public ActionResult Index()
        {
            return View();
        }

         [HttpPost]
         public ActionResult MakeNewOrder(Order newOrder)
         {
            newOrder.Id = m_IdGenerator.GenerateId();
            newOrder.CreationDate = DateTime.Today;
            newOrder.CreationId = m_OrderHelperInfoService.GetCreationId();

            m_OrderNumberGenerator.GenerateOrderNumber(newOrder);

            m_ModelsDbContext.Orders.Add(newOrder);
            m_ModelsDbContext.SaveChanges();

            return View("OrderCreated", newOrder.Number);
         }
    }
}
