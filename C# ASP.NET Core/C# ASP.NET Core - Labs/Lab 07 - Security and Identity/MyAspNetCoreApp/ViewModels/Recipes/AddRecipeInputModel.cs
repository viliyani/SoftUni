using Microsoft.AspNetCore.Http;
using MyAspNetCoreApp.Controllers;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyAspNetCoreApp.ViewModels.Recipes
{
    public class AddRecipeInputModel
    {
        [MinLength(5)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "First time the recipe has been cooked")]
        public DateTime FirstCooked { get; set; }

        public int Year { get; set; }

        public RecipeTimeInputModel Time { get; set; }

        public string[] Ingredients { get; set; }

        public IFormFile Image { get; set; }
    }
}
