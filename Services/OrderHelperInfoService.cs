using System;
using OrderWebApp.Models;

namespace OrderWebApp.Services
{
    public class OrderHelperInfoService
    {
        private ModelsDbContext m_ModelsDbContext;
        public OrderHelperInfoService(ModelsDbContext modelsDbContext)
        {
            m_ModelsDbContext = modelsDbContext;
        }

        public int GetCreationId()
        {
            OrderHelperInfo orderHelperInfo = m_ModelsDbContext.OrderHelperInfo.Find(DateTime.Today);

            if(orderHelperInfo == null)
            {
                orderHelperInfo = CreateTodayOrderHelperInfo();
            }

            orderHelperInfo.CreatedOrdersAmount++;

            m_ModelsDbContext.OrderHelperInfo.Update(orderHelperInfo);
            m_ModelsDbContext.SaveChanges();

            return orderHelperInfo.CreatedOrdersAmount;
        }

        private OrderHelperInfo CreateTodayOrderHelperInfo()
        {
            OrderHelperInfo todayOrderHelperInfo = new OrderHelperInfo
            {
                Date = DateTime.Today,
                CreatedOrdersAmount = 0
            };

            m_ModelsDbContext.OrderHelperInfo.Add(todayOrderHelperInfo);
            m_ModelsDbContext.SaveChanges();

            return todayOrderHelperInfo;
        }
    }
}
