using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override ICollection<Type> PreferredFoods
        {
            get
            {
                return new List<Type>() { typeof(Vegetable), typeof(Meat) };
            }
        }

        public override double WeightMultiplier
        {
            get
            {
                return 0.30;
            }
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
