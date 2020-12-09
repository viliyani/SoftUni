using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override ICollection<Type> PreferredFoods
        {
            get
            {
                return new List<Type>() { typeof(Meat) };
            }
        }

        public override double WeightMultiplier
        {
            get
            {
                return 1.00;
            }
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
