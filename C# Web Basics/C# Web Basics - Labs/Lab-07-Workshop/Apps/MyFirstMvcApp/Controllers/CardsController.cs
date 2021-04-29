using MyFirstMvcApp.Data;
using MyFirstMvcApp.ViewModels;
using SUS.HTTP;
using SUS.MvcFramework;
using System.Linq;

namespace MyFirstMvcApp.Controllers
{
    public class CardsController : Controller
    {
        public HttpResponse Add()
        {
            return View();
        }

        [HttpPost("/cards/add")]
        public HttpResponse DoAdd()
        {
            var db = new ApplicationDbContext();

            if (Request.FormData["name"].Length < 5)
            {
                return Error("Name should be at least 5 characters long.");
            }

            db.Cards.Add(new Card
            {
                Attack = int.Parse(Request.FormData["attack"]),
                Health = int.Parse(Request.FormData["health"]),
                Description = Request.FormData["description"],
                Name = Request.FormData["name"],
                ImageUrl = Request.FormData["image"],
                Keyword = Request.FormData["keyword"],
            });

            db.SaveChanges();

            var viewModel = new DoAddViewModel
            {
                Attack = int.Parse(Request.FormData["attack"]),
                Health = int.Parse(Request.FormData["health"]),
            };

            return View(viewModel);
        }

        public HttpResponse All()
        {
            var db = new ApplicationDbContext();

            var cardsViewModel = db
                .Cards
                .Select(x => new CardViewModel
                {
                    Name = x.Name,
                    Description = x.Description,
                    Attack = x.Attack,
                    Health = x.Health,
                    ImageUrl = x.ImageUrl,
                    Type = x.Keyword
                })
                .ToList();

            return View(new AllCardsViewModel
            {
                Cards = cardsViewModel
            });
        }

        public HttpResponse Collection()
        {
            return View();
        }
    }
}
