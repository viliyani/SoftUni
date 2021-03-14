using Microsoft.EntityFrameworkCore;
using EfCodeFirstDemo.Models;

namespace EfCodeFirstDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new SlidoDbContext();
            db.Database.Migrate();
        }
    }
}
