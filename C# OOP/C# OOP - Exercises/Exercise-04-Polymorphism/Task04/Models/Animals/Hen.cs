using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override ICollection<Type> PreferredFoods
        {
            get
            {
                return new List<Type>() { typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds) };
            }
        }

        public override double WeightMultiplier
        {
            get
            {
                return 0.35;
            }
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
