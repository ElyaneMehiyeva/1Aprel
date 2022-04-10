using System;
using System.Collections.Generic;
using System.Text;

namespace RestoranOrdersSystem
{
    internal class RestaurantManager : IRestaurantManager
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public List<Order> Orders { get; set; } = new List<Order>();

        public void AddMenuItem(string name, double price, MenuCategory category)
        {
            MenuItem item = new MenuItem()
            {
                Name = name,
                Price = price,
                Category = category
            };
            MenuItems.Add(item);
        }

        public void AddOrder(MenuItem menuItem, int count)
        {
        }

        public void EditMenuItem(string no, string newName, double newPrice)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> GetMenuItemsByCategory(MenuCategory category)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> GetMenuItemsByPriceInterval(double minPrice, double maxPrice)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrderByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByNO(int no)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByDatesInterval(DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByPriceInterval(double minPrice, double maxPrice)
        {
            throw new NotImplementedException();
        }

        public void RemoveMenuItem(string no)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrder(int no)
        {
            throw new NotImplementedException();
        }
    }
}
