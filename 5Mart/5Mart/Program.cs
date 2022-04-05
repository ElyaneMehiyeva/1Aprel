using System;

namespace _5Mart
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                Name = "Zumrut Anka",
                AuthorName = "Harry Poter",
                Price = 23.5,
                Genre = Genre.Dram
            };
            Book book2 = new Book()
            {
                Name = "Tiamat",
                AuthorName = "İhsan Oktay Anar",
                Price = 22.10,
                Genre = Genre.Comedy
            }; ;
            Book book3 = new Book()
            {
                Name = "Çocuk Köstebek Tilki ve At",
                AuthorName = "Charlie Mackesy",
                Price = 34.5,
                Genre= Genre.Dedektiv
            }; ;
            Book book4 = new Book()
            {
                Name = "İmzalı - Kırk Kere Söyledim - Ben Ne Söyledim Çocuğum Ne ...",
                AuthorName = "Ziya Selcuk",
                Price = 38.5,
                Genre=Genre.Dedektiv
            };
            Library library = new Library();
            library.books.Add(book1);
            library.books.Add(book2);
            library.books.Add(book3);
            library.books.Add(book4);
            Console.WriteLine("Qiymete gore filtirlendi :");
            foreach (Book book in library.FilterByPrice(24,35))
            {
                Console.WriteLine(book.Name + " " + book.Price);
            }
            Console.WriteLine("\n\nJanra gore filtirlendi :");
            foreach (Book book in library.FilterByGenre(Genre.Dedektiv))
            {
                Console.WriteLine(book.Name + " " + book.Price + " " + book.Genre);
            }
        }
    }
}

