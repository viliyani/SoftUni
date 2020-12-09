using System;
using WildFarm.Common;
using WildFarm.Models.Animals;

namespace WildFarm.Factories
{
    public class AnimalFactory
    {
        public Animal Create(string type, string name, double weight, string[] args)
        {
            Animal animal;

            if (args.Length == 1)
            {
                double wingSize;
                bool isBird = double.TryParse(args[0], out wingSize);

                if (isBird)
                {
                    if (type == "Hen")
                    {
                        animal = new Hen(name, weight, wingSize);
                    }
                    else if (type == "Owl")
                    {
                        animal = new Owl(name, weight, wingSize);
                    }
                    else
                    {
                        throw new InvalidOperationException(ExceptionMessages.InvalidTypeMsg);
                    }
                }
                else
                {
                    string livingRegion = args[0];

                    if (type == "Mouse")
                    {
                        animal = new Mouse(name, weight, livingRegion);
                    }
                    else if (type == "Dog")
                    {
                        animal = new Dog(name, weight, livingRegion);
                    }
                    else
                    {
                        throw new InvalidOperationException(ExceptionMessages.InvalidTypeMsg);
                    }
                }
            }
            else if (args.Length == 2)
            {
                string livingRegion = args[0];
                string breed = args[1];

                if (type == "Cat")
                {
                    animal = new Cat(name, weight, livingRegion, breed);
                }
                else if (type == "Tiger")
                {
                    animal = new Tiger(name, weight, livingRegion, breed);
                }
                else
                {
                    throw new InvalidOperationException(ExceptionMessages.InvalidTypeMsg);
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidTypeMsg);
            }

            return animal;
        }


    }
}
