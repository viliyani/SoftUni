using MyFirstMvcApp.Data;
using MyFirstMvcApp.ViewModels.Cards;
using SUS.HTTP;
using SUS.MvcFramework;
using System.Linq;

namespace MyFirstMvcApp.Controllers
{
    public class CardsController : Controller
    {
        private readonly ApplicationDbContext db;

        public CardsController(ApplicationDbContext db)
        {
            this.db = db;
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
        public HttpResponse DoAdd(AddCardInputModel model)
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/users/login");
            }

            if (model.Name.Length < 5)
            {
                return Error("Name should be at least 5 characters long.");
            }

            db.Cards.Add(new Card
            {
                Attack = model.Attack,
                Health = model.Health,
                Description = model.Description,
                Name = model.Name,
                ImageUrl = model.Image,
                Keyword = model.Keyword,
            });

            db.SaveChanges();

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

            return View(cardsViewModel);
        }

        public HttpResponse Collection()
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/users/login");
            }

            return View();
        }
    }
}
