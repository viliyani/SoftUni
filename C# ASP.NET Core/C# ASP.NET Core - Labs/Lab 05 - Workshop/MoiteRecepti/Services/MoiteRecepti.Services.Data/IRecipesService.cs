namespace MoiteRecepti.Services.Data
{
    using MoiteRecepti.Web.ViewModels.Recipes;
    using System.Threading.Tasks;

    public interface IRecipesService
    {
        Task CreateAsync(CreateRecipeInputModel input);

    }
}
