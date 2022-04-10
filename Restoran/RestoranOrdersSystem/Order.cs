using System;
using System.Collections.Generic;
using System.Text;

namespace RestoranOrdersSystem
{
    internal class Order
    {
        private static int _no;
        public Order()
        {
            _no++;
            this.No = _no;
        }
        public int No { get; }
        public List<Order> OrderItems { get; set; }
        public double TotalAmount { get; set; }
        public DateTime Date { get; set; }


    }
}
