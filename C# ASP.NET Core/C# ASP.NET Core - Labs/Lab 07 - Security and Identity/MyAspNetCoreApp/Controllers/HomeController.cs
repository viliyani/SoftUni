using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyAspNetCoreApp.Data;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Service;
using MyAspNetCoreApp.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext dbContext;

        public HomeController(
            ILogger<HomeController> logger,
            ApplicationDbContext dbContext,
            IInstanceCounter instanceCounter
            )
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Year = DateTime.UtcNow.Year,
                UsersCount = dbContext.Users.Count(),
                ProcessorsCount = Environment.ProcessorCount,
                Name = "John",
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult AjaxDemo()
        {
            return View();
        }

        public IActionResult AjaxDemoData()
        {
            return this.Json(new[] {
                new { Name = "User1", Date = DateTime.UtcNow.ToString("O")},
                new { Name = "User2", Date = DateTime.UtcNow.ToString("O")},
                new { Name = "User3", Date = DateTime.UtcNow.ToString("O")},
            });
        }

    }
}
