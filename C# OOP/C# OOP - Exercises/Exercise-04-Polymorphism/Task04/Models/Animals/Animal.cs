using System;
using System.Collections.Generic;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal, IFeedable, ISoundProducable
    {
        private const string INV_FOOD_TYPE = "{0} does not eat {1}!";

        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public int FoodEaten { get; private set; }

        public string Name { get; }

        public double Weight { get; private set; }

        public abstract double WeightMultiplier { get; }

        public abstract ICollection<Type> PreferredFoods { get; }

        public void Feed(IFood food)
        {
            if (!PreferredFoods.Contains(food.GetType()))
            {
                throw new InvalidOperationException(String.Format(INV_FOOD_TYPE, this.GetType().Name, food.GetType().Name));
            }

            FoodEaten += food.Quantity;
            Weight += food.Quantity * WeightMultiplier;
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
