using MyFirstMvcApp.Data;
using MyFirstMvcApp.Services;
using MyFirstMvcApp.ViewModels.Cards;
using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Linq;

namespace MyFirstMvcApp.Controllers
{
    public class CardsController : Controller
    {
        private readonly ICardsService cardsService;

        public CardsController(ICardsService cardsService)
        {
            this.cardsService = cardsService;
        }

        public HttpResponse Add()
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/users/login");
            }

            return View();
        }

        [HttpPost("/cards/add")]
        public HttpResponse Add(AddCardInputModel model)
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/users/login");
            }

            if (string.IsNullOrEmpty(model.Name) || model.Name.Length < 5 || model.Name.Length > 15)
            {
                return Error("Name should be between 5 and 15 characters long.");
            }

            if (string.IsNullOrWhiteSpace(model.Image))
            {
                return Error("The image is required!");
            }

            if (string.IsNullOrWhiteSpace(model.Keyword))
            {
                return Error("Keyword is required.");
            }

            if (model.Attack < 0)
            {
                return Error("Attack should be non-negative integer.");
            }

            if (model.Health < 0)
            {
                return Error("Health should be non-negative integer.");
            }

            if (string.IsNullOrWhiteSpace(model.Description) || model.Description.Length > 200)
            {
                return Error("Description is required and its length should be at most 200 characters.");
            }

            var cardId = cardsService.AddCard(model);
            var userId = GetUserId();

            cardsService.AddCardToUserCollection(userId, cardId);

            var viewModel = new DoAddViewModel
            {
                Attack = model.Attack,
                Health = model.Health,
            };

            return View(viewModel);
        }

        public HttpResponse All()
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/users/login");
            }

            var db = new ApplicationDbContext();

            var cardsViewModel = cardsService.GetAll();

            return View(cardsViewModel);
        }

        public HttpResponse Collection()
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/users/login");
            }

            var userId = GetUserId();
            var viewModel = cardsService.GetByUserId(userId);

            return View(viewModel);
        }

        public HttpResponse AddToCollection(int cardId)
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/users/login");
            }

            var userId = GetUserId();

            cardsService.AddCardToUserCollection(userId, cardId);

            return Redirect("/cards/all");
        }

        public HttpResponse RemoveFromCollection(int cardId)
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/users/login");
            }

            var userId = GetUserId();

            cardsService.RemoveCardFromUserCollection(userId, cardId);

            return Redirect("/cards/collection");
        }
    }
}
