using System;
using System.Collections.Generic;
using System.Text;

namespace _6Aprel
{
    internal class Shop
    {
        List<Order>orders = new List<Order>();
        public void AddOrder(Order order)
        {
           orders.Add(order);
        }
        public double GetOrderAvg()
        {           
            double sum = 0;
            foreach (Order order in orders)
            {
                sum += order.TotalAmount;
            }
            return sum / orders.Count;
        }
        public double GetOrdersAvg(DateTime time)
        {
            var result = orders.FindAll(order => order.CreatedAt > time);
            double sum = 0;
            foreach(Order order in result)
            {
                sum += order.TotalAmount;
            }
            return sum / result.Count;
        }
        public void RemoveOrderByNo(int no)
        {
            var order = orders.Find(order=>order.No == no);
            orders.Remove(order);
        }
        public List<Order> FilterOrderByPrice(double minPrice, double maxPrice)
        {
            var result = orders.FindAll(order => order.TotalAmount>minPrice && order.TotalAmount < maxPrice);
            return result;
        }
    }
}
