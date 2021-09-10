using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.ModelBinders;
using MyAspNetCoreApp.ViewModels.Recipes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.Controllers
{
    public class RecipesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            var model = new AddRecipeInputModel
            {
                FirstCooked = DateTime.UtcNow,
                Time = new RecipeTimeInputModel()
                {
                    CookingTime = 10,
                    PreparationTime = 5
                }
            };

            return this.View(model);
        }

        public IActionResult Add(AddRecipeInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            // TODO: Save data


            return this.RedirectToAction("ThankYou");
        }

        [HttpGet]
        public IActionResult ThankYou()
        {
            return this.View();
        }


    }
}
