namespace MoiteRecepti.Web.Controllers
{
    using System.Diagnostics;

    using MoiteRecepti.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using MoiteRecepti.Web.ViewModels.Home;
    using MoiteRecepti.Data;
    using System.Linq;
    using MoiteRecepti.Data.Common.Repositories;
    using MoiteRecepti.Data.Models;
    using MoiteRecepti.Services.Data;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService countsService;

        public HomeController(IGetCountsService countsService)
        {
            this.countsService = countsService;
        }

        public IActionResult Index()
        {
            var viewModel = countsService.GetCounts();
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
