using CodeFirstDemo.Models;
using System;
using System.Collections.Generic;

namespace CodeFirstDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create the database from classes
            var db = new ApplicationDbContext();
            db.Database.EnsureCreated();

            // Example
            db.Categories.Add(new Category
            {
                Title = "Sport",
                News = new List<News>
                {
                    new News
                    {
                        Title = "Sport Event Title",
                        Content = "Lorem ipsum dolor sit amet",
                        Comments = new List<Comment>
                        {
                            new Comment {Author = "User", Content = "Nice post!" },
                            new Comment {Author = "John", Content = "Interesting!" },
                        }
                    }
                }
            });
            db.SaveChanges();
        }
    }
}
