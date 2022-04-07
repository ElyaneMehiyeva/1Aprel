using System;
using System.Collections.Generic;
using System.Text;

namespace _7Aprel
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public void ShowInfo()
        {
            string showInfo = $"Name : {Name}, AuthorName : {AuthorName}, Price : {Price}, Id : {Id}";
            Console.WriteLine(showInfo);
        }
    }
}
