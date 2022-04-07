using System;
using System.IO;
using Newtonsoft.Json;
namespace _7Aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullPath = @"C:\Users\User\Desktop\Tasklar\7Aprel\7Aprel\";
            Directory.CreateDirectory(fullPath + "Files");
            if(!File.Exists(fullPath + @"Files\Database.json"))
            {
                var file = File.Create(fullPath + @"Files\Database.json");
                file.Close();
            }
            Library library = new Library()
            {
                Name = "Libraff",
                Id = 1
            };
            bool menuIsActive = true;
            while (menuIsActive)
            {
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Add book\n2. Get book by id\n3. Remove book\n0. Quit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Kitab adini daxil edin :");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("Kitab muellifini daxil edin :");
                        string bookAuthorName = Console.ReadLine();
                        Console.WriteLine("Kitab id-ni daxil edin :");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Kitab qiymetini daxil edin :");
                        double bookPrice = double.Parse(Console.ReadLine());
                        Book book1 = new Book()
                        {
                            Id = bookId,
                            Name = bookName,
                            AuthorName = bookAuthorName,                            
                            Price = bookPrice,
                        };
                        library.Books.Add(book1);
                        string json = JsonConvert.SerializeObject(library);
                        using(StreamWriter streamWriter = new StreamWriter(fullPath + @"Files\Database.json"))
                        {
                            streamWriter.WriteLine(json);
                        }
                        break;
                    case "2":
                        Console.WriteLine("ID daxil edin :");
                        int id = int.Parse(Console.ReadLine());
                        string content = null;
                        using (StreamReader streamReader = new StreamReader(fullPath + @"Files\Database.json"))
                        {
                            content = streamReader.ReadToEnd();
                        }
                        Library newLib = JsonConvert.DeserializeObject<Library>(content);
                        Book searchBook = newLib.GetBookById(id);
                        searchBook.ShowInfo();
                        break;
                    case "3":
                        Console.WriteLine("ID daxil edin :");
                        int id2 = int.Parse(Console.ReadLine());
                        string content2 = null;
                        using (StreamReader streamReader = new StreamReader(fullPath + @"Files\Database.json"))
                        {
                            content2 = streamReader.ReadToEnd();
                        }
                        Library newLib2 = JsonConvert.DeserializeObject<Library>(content2);
                        newLib2.RemoveBook(id2);
                        string json2 = JsonConvert.SerializeObject(newLib2);
                        using (StreamWriter streamWriter = new StreamWriter(fullPath + @"Files\Database.json"))
                        {
                            streamWriter.WriteLine(json2);
                        }
                        break;
                    case "0":
                        menuIsActive = false;
                        break;
                    default:
                        Console.WriteLine("Yanlis Secim !");
                        break;
                }
            }
        }
    }
}
