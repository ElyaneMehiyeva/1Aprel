
using System;
using System.Collections.Generic;

namespace _8Aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Menu : \n1. Telebe elave et\n2. Telebeye imtahan elave et\n3. Telebenin bir imtahan balina bax\n4. Telebenin butun imtahanlarini goster\n5. Telebenin imtahan ortalamasini goster\n6. Telebeden imtahan sil\n0. Proqrami bitir\n");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("FullName daxil edin :");
                        string fullName = Console.ReadLine();
                        Student student = new Student();
                        student.FullName = fullName;
                        Students.Add(student);
                        break;
                    case "2":
                        Console.WriteLine("Telebenin nomresini daxil edin : ");
                        int no = int.Parse(Console.ReadLine());                       
                        Console.WriteLine("Imtahan adini daxil edin : ");
                        string examName = Console.ReadLine();
                        Console.WriteLine("Imtahan balini daxil edin :");
                        double studentPoint = double.Parse(Console.ReadLine());
                        Student searchStudent = Students.Find(std => std.No == no);
                        if(searchStudent != null)
                        {
                            searchStudent.AddExam(examName, studentPoint);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Telebe nomresini daxil edin :");
                        int stdNo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imtahan Adini daxil edin :");
                        string examName2 = Console.ReadLine();
                        Student std = Students.Find(std => std.No == stdNo);
                        if(std != null)
                        {
                            Console.WriteLine(std.GetExamResult(examName2));
                        }
                        break;
                    case "4":
                        Console.WriteLine("No daxil edin :");
                        int stdNo2 = int.Parse(Console.ReadLine());
                        Student std2 = Students.Find(std => std.No == stdNo2);
                        if(std2 != null)
                        {
                            foreach (var item in std2.Exams)
                            {
                                Console.WriteLine(item.Key + " - " + item.Value);
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("No daxil edin :");
                        int stdNo3 = int.Parse(Console.ReadLine());
                        Student std3 = Students.Find(std => std.No == stdNo3);
                        if(std3 != null)
                        {
                            Console.WriteLine(std3.GetExamAvg());
                        }
                        break;
                    case "6":
                        Console.WriteLine("No daxil edin :");
                        int stdNo4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imtahan Adi :");
                        string examName3 = Console.ReadLine();
                        Student std4 = Students.Find(std => std.No == stdNo4);
                        if(std4 != null)
                        {
                            std4.Exams.Remove(examName3);
                        }
                        break;
                    case "0":
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Yanlis secim !");
                        break;
                }
            }
        }
    }
}