namespace MoiteRecepti.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using MoiteRecepti.Services.Data;
    using MoiteRecepti.Web.ViewModels.Recipes;

    public class RecipesController : BaseController
    {
        private readonly ICategoriesService categoriesService;
        private readonly IRecipesService recipesService;

        public RecipesController(
            ICategoriesService categoriesService,
            IRecipesService recipesService)
        {
            this.categoriesService = categoriesService;
            this.recipesService = recipesService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateRecipeInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRecipeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            await this.recipesService.CreateAsync(input);

            return this.Redirect("/");
        }

    }
}
