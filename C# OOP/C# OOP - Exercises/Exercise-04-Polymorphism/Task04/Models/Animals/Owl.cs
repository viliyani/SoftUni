using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier
        {
            get
            {
                return 0.25;
            }
        }

        public override ICollection<Type> PreferredFoods
        {
            get
            {
                return new List<Type>() { typeof(Meat) };
            }
        }



        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
