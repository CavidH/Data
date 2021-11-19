using System;
using Data.DAL;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                
           
            Console.WriteLine("Hello");
            Console.WriteLine("" +
                              "MENYU" +
                              "1-Add Student" +
                              "2-Delete Student" +
                              "3-Update Student" +
                              "4-Read Student");
            int a=int.Parse(Console.ReadLine());
            if (a==1)
            {
                Console.WriteLine("Ad daxil edin:");
                string name = Console.ReadLine();
                Console.WriteLine("soyAd daxil edin:");
                string surname = Console.ReadLine();
                CreateStudent(new Student()
                {
                    Name = surname,
                    SurName = "Haciyev"
                });
            }
            }

            
        }
        public static  void CreateStudent(Student sd)
        {
            AppDbContext appContext = new AppDbContext();
            
            appContext.Students.Add(sd);
            appContext.SaveChanges();
            Console.WriteLine("ok");
                
        }
    }
}
