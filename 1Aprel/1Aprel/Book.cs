using System;
using System.Collections.Generic;
using System.Text;

namespace _1Aprel
{
    internal class Book
    {
        private static int _no;
        public Book()
        {
            _no++;
            this.No = _no;
        }
        public int No { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
    }
}
