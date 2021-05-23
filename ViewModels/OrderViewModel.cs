using System;
using OrderWebApp.Models;

namespace OrderWebApp.ViewModels
{
    public class OrderViewModel
    {
        private Order m_Order;

        public String Number
        { 
            get
            {
                return m_Order.Number;
            }
        }
  
        public String SenderCity
        {
            get
            {
                return m_Order.SenderCity;
            }
        }

        public String SenderAddress
        {
            get
            {
                return m_Order.SenderAddress;
            }
        }

        public String RecipientCity
        {
            get
            {
                return m_Order.RecipientCity;
            }
        }

        public String RecipientAddress
        {
            get
            {
                return m_Order.RecipientAddress;
            }
        }

        public int PackageWeightInkilograms
        {
            get
            {
                return m_Order.PackageWeightInkilograms;
            }
        }

        public String PackagePickUpDate
        {
            get
            {
                return m_Order.PackagePickUpDate.ToString("dd.MM.yyyy");
            }
        }
        public OrderViewModel(Order order)
        {
            m_Order = order;
        }
    }
}
