using System;
using System.Collections.Generic;
using System.Text;

namespace _5Mart
{
    internal class Library
    {
        public List<Book> books = new List<Book>();
        public List<Book> FilterByPrice(double min, double max)
        {
            return books.FindAll(book=>(book.Price > min && book.Price < max));
        }
        public List<Book> FilterByGenre(Genre genre)
        {
            return books.FindAll(book => (book.Genre==genre));
        }
        public Book FİndBookByNo(int? no)
        {
            if (no == null)
                throw new Exception("No null -dur");
            Book searchBook = books.Find(book=>book.No==no);
            if(searchBook == null)
            {
                return null;
            } else
            {
                return searchBook;
            }
        }
    }
}
