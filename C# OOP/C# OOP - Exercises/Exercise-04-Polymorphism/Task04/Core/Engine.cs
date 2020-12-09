using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Core.Contracts;
using WildFarm.Factories;
using WildFarm.Models.Animals;
using WildFarm.Models.Foods;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private readonly ICollection<Animal> animals;

        private readonly AnimalFactory animalFactory;
        private readonly FoodFactory foodFactory;

        public Engine()
        {
            animalFactory = new AnimalFactory();
            foodFactory = new FoodFactory();
            animals = new HashSet<Animal>();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] animalArgs = command.Split();

                string type = animalArgs[0];
                string name = animalArgs[1];
                double weight = double.Parse(animalArgs[2]);
                string[] args = animalArgs.Skip(3).ToArray();

                Animal animal = null;

                try
                {
                    animal = animalFactory.Create(type, name, weight, args);

                    this.animals.Add(animal);

                    Console.WriteLine(animal.ProduceSound());
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                string[] foodArgs = Console.ReadLine().Split();

                string foodType = foodArgs[0];
                int foodQty = int.Parse(foodArgs[1]);

                try
                {
                    Food food = this.foodFactory.CreateFood(foodType, foodQty);

                    if (animal != null)
                    {
                        animal.Feed(food);
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }


    }
}
