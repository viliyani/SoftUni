using PizzaCalories.Models;
using System;
using System.Linq;

namespace PizzaCalories.Core
{
    public class Engine
    {

        public void Run()
        {
            try
            {
                Pizza pizza = CreatePizza();
                Dough dough = CreateDough();

                pizza.Dough = dough;

                AddToppingsToPizza(pizza);

                Console.WriteLine(pizza);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private Pizza CreatePizza()
        {
            string[] pizzaArgs = Console.ReadLine()
                                        .Split();

            string pizzaName = pizzaArgs[1];
            Pizza pizza = new Pizza(pizzaName);

            return pizza;
        }

        private static Dough CreateDough()
        {
            string[] doughArgs = Console.ReadLine()
                                           .Split();

            string flourType = doughArgs[1];
            string bakingTechnique = doughArgs[2];
            double doughtWeight = double.Parse(doughArgs[3]);

            Dough dough = new Dough(flourType, bakingTechnique, doughtWeight);

            return dough;
        }

        private void AddToppingsToPizza(Pizza pizza)
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] toppingArgs = input
                                        .Split()
                                        .Skip(1)
                                        .ToArray();

                string toppingType = toppingArgs[0];
                double toppingWeight = double.Parse(toppingArgs[1]);
                Topping topping = new Topping(toppingType, toppingWeight);

                pizza.AddTopping(topping);
            }
        }
    }
}
