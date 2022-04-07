using System;
using System.Collections.Generic;
using System.Text;

namespace _7Aprel
{
    internal class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public Book GetBookById(int id)
        {
            return Books.Find(b => b.Id == id);
        }
        public void RemoveBook(int id)
        {
            var book = Books.Find(b => b.Id == id);
            Books.Remove(book);
        }
    }
}
