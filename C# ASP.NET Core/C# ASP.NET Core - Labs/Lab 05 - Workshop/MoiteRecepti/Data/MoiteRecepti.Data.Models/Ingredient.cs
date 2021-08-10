using MoiteRecepti.Data.Common.Models;
using System.Collections.Generic;

namespace MoiteRecepti.Data.Models
{
    public class Ingredient : BaseDeletableModel<int>
    {
        public Ingredient()
        {
            Recipes = new HashSet<RecipeIngredient>();
        }

        public string Name { get; set; }

        public ICollection<RecipeIngredient> Recipes { get; set; }

    }
}
