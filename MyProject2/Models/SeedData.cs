using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyProject2.Data;
using MyProject2.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace MyProject2.Models
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyProject2Context(serviceProvider.GetRequiredService<DbContextOptions<MyProject2Context>>()))
            {

                // if (!context.Blog.Any())


                Blog blog = new Blog();
                blog.Url = "http://www.goo.com";

                Post post1 = new Post
                {
                    Title = "hello",
                    Content = "A test content.",
          
                };
                Post post2 = new Post
                {
                    Title = "hello2",
                    Content = "A test content 2.",
      
                };
                blog.Posts = new List<Post>();
                blog.Posts.Add(post1);
                blog.Posts.Add(post2);

                context.Blogs.Add(blog);

                context.SaveChanges();
            }
        }
    }
}