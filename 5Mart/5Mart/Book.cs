using System;
using System.Collections.Generic;
using System.Text;

namespace _5Mart
{
    internal class Book
    {
        private static int _no;
        public Book()
        {
            _no++;
            No = _no;
        }
        public int No { get;  }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Genre { get; set; }
        public double Price { get; set; }
    }
}
