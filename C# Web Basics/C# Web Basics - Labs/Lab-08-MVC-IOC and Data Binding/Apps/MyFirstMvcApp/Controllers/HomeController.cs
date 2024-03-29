﻿using MyFirstMvcApp.ViewModels;
using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Linq;
using System.Text;

namespace MyFirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public HttpResponse Index()
        {
            if (IsUserSignedIn())
            {
                return Redirect("/cards/all");
            }
            else
            {
                var viewModel = new IndexViewModel();
                viewModel.CurrentYear = DateTime.UtcNow.Year;
                viewModel.Message = "Welcome to Battle Cards";

                return View(viewModel);
            }
        }

        [HttpGet("/about")]
        public HttpResponse About()
        {
            SignIn("john");
            return View();
        }

    }
}
