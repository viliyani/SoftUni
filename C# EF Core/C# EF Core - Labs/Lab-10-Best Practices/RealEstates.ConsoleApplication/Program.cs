using Microsoft.EntityFrameworkCore;
using RealEstates.Data;
using RealEstates.Models;
using System;

namespace RealEstates.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            db.Database.Migrate();

            db.Districts.Add(new District { Name = "Дианабад" });
            db.SaveChanges();
        }
    }
}
