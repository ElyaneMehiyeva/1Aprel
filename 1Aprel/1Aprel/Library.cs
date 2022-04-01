using System;
using System.Collections.Generic;
using System.Text;

namespace _1Aprel
{
    internal class Library
    {
        List<Book> Books = new List<Book>();
        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> FilteredBooks = new List<Book>();
            foreach (Book book in Books)
            {
                FilteredBooks.Add(book);
            }
            return FilteredBooks;
        }
        public void RemoveAllBookByName(string value)
        {
            foreach (Book book in Books)
            {
                if(book.Name.Contains(value))
                {
                    Books.Remove(book);
                }
            }
            
        }
        public List<Book> SearchBooks(string value)
        {
            List<Book> newbooks = new List<Book>();
            foreach (Book book in Books)
            {
                string text = book.Name + book.AuthorName + book.PageCount;
                if (text.Contains(value))
                {
                    newbooks.Add(book);
                }
            }
            return newbooks;
        }
        public List<Book> FindAllBooksByPageCountRange(int minCount, int maxCount)
        {
            List<Book> FilteredForPageCount = new List<Book>();
            foreach(Book book in Books)
            {
                if (book.PageCount>minCount && book.PageCount<maxCount)
                {
                    FilteredForPageCount.Add(book);
                }
            }
            return FilteredForPageCount;
        }
        public void RemoveByCode(int value)
        {
            foreach(Book book in Books)
            {
                if (book.No == value)
                {
                    Books.Remove(book);
                }
            }
        }
    }
}
