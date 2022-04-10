using System;
using System.Collections.Generic;
using System.Text;

namespace RestoranOrdersSystem
{
    internal interface IRestaurantManager
    {
        public List<MenuItem> MenuItems { get; set; }
        public List<Order> Orders { get; set; }
        public void AddOrder(MenuItem menuItem,int count);
        public void RemoveOrder(int no);
        public List<Order> GetOrdersByDatesInterval(DateTime fromDate,DateTime toDate); 
        public List<Order> GetOrderByDate(DateTime date);
        public List<Order> GetOrdersByPriceInterval(double minPrice,double maxPrice);
        public Order GetOrderByNO(int no);
        public void AddMenuItem(string name,double price,MenuCategory category);
        public void RemoveMenuItem(string no);
        public void EditMenuItem(string no,string newName,double newPrice);
        public List<MenuItem> GetMenuItemsByCategory(MenuCategory category);
        public List<MenuItem> GetMenuItemsByPriceInterval(double minPrice,double maxPrice);
    }
}
