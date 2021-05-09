using Suls.Services;
using SUS.HTTP;
using SUS.MvcFramework;

namespace Suls.Controllers
{
    public class ProblemsController : Controller
    {
        private readonly IProblemsService problemsService;

        public ProblemsController(IProblemsService problemsService)
        {
            this.problemsService = problemsService;
        }

        public HttpResponse Create()
        {
            return View();
        }

        [HttpPost]
        public HttpResponse Create(string name, int points)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 5 || name.Length > 20)
            {
                return Error("Name should be between 5 and 20 characters.");
            }

            if (points < 50 || points > 300)
            {
                return Error("Points should be between 50 and 300.");
            }

            problemsService.Create(name, (ushort)points);
            return Redirect("/");
        }

        public HttpResponse Details(string id)
        {
            var viewModel = problemsService.GetById(id);
            return View(viewModel);
        }

    }
}
