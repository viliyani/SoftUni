using MoiteRecepti.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoiteRecepti.Web.ViewModels.Recipes
{
    public class CreateRecipeInputModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Required]
        [MinLength(100)]
        public string Instructions { get; set; }

        [Range(0, 24 * 60)]
        [Display(Name = "Preparation Time")]
        public int PreparationTime { get; set; }

        [Range(0, 24 * 60)]
        [Display(Name = "Cooking Time")]
        public int CookingTime { get; set; }

        [Range(1, 100)]
        public int PortionsCount { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<RecipeIngredientInputModel> Ingredients { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
    }
}
