using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override ICollection<Type> PreferredFoods
        {
            get
            {
                return new List<Type>() { typeof(Vegetable), typeof(Fruit) };
            }
        }

        public override double WeightMultiplier
        {
            get
            {
                return 0.10;
            }
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
