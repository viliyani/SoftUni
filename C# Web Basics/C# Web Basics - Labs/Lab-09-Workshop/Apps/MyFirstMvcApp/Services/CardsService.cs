using MyFirstMvcApp.Data;
using MyFirstMvcApp.ViewModels.Cards;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstMvcApp.Services
{
    public class CardsService : ICardsService
    {
        private readonly ApplicationDbContext db;

        public CardsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddCard(AddCardInputModel input)
        {
            var card = new Card
            {
                Attack = input.Attack,
                Health = input.Health,
                Description = input.Description,
                Name = input.Name,
                ImageUrl = input.Image,
                Keyword = input.Keyword,
            };

            db.Cards.Add(card);

            db.SaveChanges();

            return card.Id;
        }

        public IEnumerable<CardViewModel> GetAll()
        {
            return db.Cards
                .Select(x => new CardViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Attack = x.Attack,
                    Health = x.Health,
                    ImageUrl = x.ImageUrl,
                    Type = x.Keyword
                })
                .ToList();
        }

        public IEnumerable<CardViewModel> GetByUserId(string userId)
        {
            return db.UserCards
                .Where(x => x.UserId == userId)
                .Select(x => new CardViewModel
                {
                    Id = x.Card.Id,
                    Attack = x.Card.Attack,
                    Health = x.Card.Health,
                    Description = x.Card.Description,
                    ImageUrl = x.Card.ImageUrl,
                    Name = x.Card.Name,
                    Type = x.Card.Keyword,
                })
                .ToList();
        }

        public void AddCardToUserCollection(string userId, int cardId)
        {
            if (db.UserCards.Any(x => x.UserId == userId && x.CardId == cardId))
            {
                return;
            }

            db.UserCards.Add(new UserCard
            {
                UserId = userId,
                CardId = cardId
            });

            db.SaveChanges();
        }

        public void RemoveCardFromUserCollection(string userId, int cardId)
        {
            var userCard = db.UserCards
                            .FirstOrDefault(x => x.UserId == userId && x.CardId == cardId);

            if (userCard == null)
            {
                return;
            }

            db.UserCards.Remove(userCard);
            db.SaveChanges();
        }
    }
}
