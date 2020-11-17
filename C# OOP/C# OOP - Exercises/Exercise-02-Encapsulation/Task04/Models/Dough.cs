using System;
using System.Collections.Generic;

namespace PizzaCalories.Models
{
    public class Dough
    {
        private const double BaseCaloriesPerGram = 2;
        private const double MinWeight = 1;
        private const double MaxWeight = 200;
        private const string InvalidTypeExcMsg = "Invalid type of dough.";
        private const string InvalidRangeExcMsg = "Dough weight should be in the range[{0}..{1}].";

        private readonly Dictionary<string, double> DefaultFlourTypes = new Dictionary<string, double>
        {
            {"white", 1.5 },
            {"wholegrain", 1.0 },
        };

        private readonly Dictionary<string, double> DefaultBackingTechniques = new Dictionary<string, double>
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0 }
        };

        private string flourType;
        private string backingTechnique;
        private double weight;

        public Dough(string flourType, string backingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BackingTechnique = backingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (!this.DefaultFlourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(InvalidTypeExcMsg);
                }

                this.flourType = value.ToLower();
            }
        }

        public string BackingTechnique
        {
            get
            {
                return this.backingTechnique;
            }
            private set
            {
                if (!this.DefaultBackingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(InvalidTypeExcMsg);
                }

                this.backingTechnique = value.ToLower();
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException(String.Format(InvalidRangeExcMsg, MinWeight, MaxWeight));
                }
            }
        }

        public double Calories => (
            (BaseCaloriesPerGram * this.Weight)
            * this.DefaultFlourTypes[this.FlourType]
            * this.DefaultBackingTechniques[this.BackingTechnique]
            );

    }
}
