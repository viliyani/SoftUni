using System;
using System.Collections.Generic;

namespace PizzaCalories.Models
{
    public class Topping
    {
        private const double BaseCaloriesPerGram = 2;
        private const double MinWieght = 1;
        private const double MaxWeight = 50;

        private const string InvalidTypeExcMsg = "Cannot place {0} on top of your pizza.";
        private const string InvalidWeightExcMsg = "{0} weight should be in the range [{1}..{2}].";

        private readonly Dictionary<string, double> DefaultToppingTypes = new Dictionary<string, double>
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if (!this.DefaultToppingTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(String.Format(InvalidTypeExcMsg, value));
                }

                this.type = value.ToLower();
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < MinWieght || value > MaxWeight)
                {
                    throw new ArgumentException(String.Format(InvalidWeightExcMsg, this.Type, MinWieght, MaxWeight));
                }

                weight = value;
            }
        }

        public double Calories => BaseCaloriesPerGram * weight * DefaultToppingTypes[this.type];

    }
}
