using Suls.Services;
using Suls.ViewModels.Submissions;
using SUS.HTTP;
using SUS.MvcFramework;

namespace Suls.Controllers
{
    public class SubmissionsController : Controller
    {
        private readonly IProblemsService problemsService;
        private readonly ISubmissionsService submissionsService;

        public SubmissionsController(IProblemsService problemsService, ISubmissionsService submissionsService)
        {
            this.problemsService = problemsService;
            this.submissionsService = submissionsService;
        }

        public HttpResponse Create(string id)
        {
            var viewModel = new CreateViewModel
            {
                ProblemId = id,
                Name = problemsService.GetNameById(id),
            };
            return View(viewModel);
        }

        [HttpPost]
        public HttpResponse Create(string problemId, string code)
        {
            if (string.IsNullOrEmpty(code) || code.Length < 30 || code.Length > 800)
            {
                return Error("Code should be between 30 and 800 characters long.");
            }

            var userId = GetUserId();

            submissionsService.Create(problemId, userId, code);

            return Redirect("/");
        }


        public HttpResponse Delete(string id)
        {
            submissionsService.Delete(id);

            return Redirect("/");
        }
    }
}
