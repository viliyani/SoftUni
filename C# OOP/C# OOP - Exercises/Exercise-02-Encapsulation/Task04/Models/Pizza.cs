using System;
using System.Collections.Generic;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private const int MinNameLength = 1;
        private const int MaxNameLength = 15;
        private const int MinToppingsNumber = 0;
        private const int MaxToppingsNumber = 10;

        private const string InvalidNameExcMsg = "Pizza name should be between {0} and {1} symbols.";
        private const string InvalidToppingsNumExcMsg = "Number of toppings should be in range [{0}..{1}].";

        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || !(value.Length >= MinNameLength && value.Length <= MaxNameLength))
                {
                    throw new ArgumentException(String.Format(InvalidNameExcMsg, MinNameLength, MaxNameLength));
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            set
            {
                this.dough = value;
            }
        }

        public int NumberOfToppings
        {
            get
            {
                return toppings.Count;
            }
        }

        public double TotalCalories
        {
            get
            {
                double total = 0;

                total += dough.Calories;

                for (int i = 0; i < toppings.Count; i++)
                {
                    total += toppings[i].Calories;
                }

                return total;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count > MaxToppingsNumber)
            {
                throw new ArgumentException(String.Format(InvalidToppingsNumExcMsg, MinToppingsNumber, MaxToppingsNumber));
            }

            this.toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalCalories:F2} Calories.";
        }

    }
}
