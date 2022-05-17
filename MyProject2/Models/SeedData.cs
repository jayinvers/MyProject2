using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyProject2.Data;
using MyProject2.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace MyWebSite.Models
{
    public static class SeedData
    {
       


        private static Student[] AddStudent()
        {
            return new Student[]
            {
                new Student
                {
                    Name = "Jay"
                }
            };
        }
       
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyProject2Context(serviceProvider.GetRequiredService<DbContextOptions<MyProject2Context>>())){

               // if (!context.Student.Any())
                    context.Student.AddRange(AddStudent());
                
                context.SaveChanges();
            }
        }
    }
}