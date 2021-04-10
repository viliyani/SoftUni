using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Quiz.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Web.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {
        private readonly IQuizService quizService;
        private readonly IUserAnswerService userAnswerService;

        public QuizController(
            IQuizService quizService,
            IUserAnswerService userAnswerService
            )
        {
            this.quizService = quizService;
            this.userAnswerService = userAnswerService;
        }

        public IActionResult Test(int id)
        {
            quizService.StartQuiz(this.User?.Identity?.Name, id);
            var viewModel = quizService.GetQuizById(id);

            return View(viewModel);
        }
        public IActionResult Submit(int id)
        {
            foreach (var item in Request.Form)
            {
                var questionId = int.Parse(item.Key.Replace("q_", String.Empty));
                var answerId = int.Parse(item.Value);

                userAnswerService.AddUserAnswer(User.Identity.Name, questionId, answerId);
            }

            return this.RedirectToAction("Results", new { id });
        }

        public IActionResult Results(int id)
        {
            int points = userAnswerService
                .GetUserResult(User.Identity.Name, id);

            return View(points);
        }

    }
}
