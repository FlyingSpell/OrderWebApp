using System;
using OrderWebApp.Models;

namespace OrderWebApp
{
    public interface IIdGenerator
    {
        String GenerateId();
    }
    public interface IOrderNumberGenerator
    {
        void GenerateOrderNumber(Order order);
    }
}
