using System;
using System.Globalization;
using OrderWebApp.Models;

namespace OrderWebApp.Services
{
    public class HumanFriendlyOrderNumberGenerator : IOrderNumberGenerator
    {
        String pattern = "{0}-{1}";

        public void GenerateOrderNumber(Order order)
        {
            String humanFriendlyDate = order.CreationDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            order.Number = String.Format(pattern, humanFriendlyDate, order.CreationId);
        }
    }
}
