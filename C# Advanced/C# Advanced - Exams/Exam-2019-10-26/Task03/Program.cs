using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Initialize the repository (Cage)
            Cage cage = new Cage("Wildness", 20);

            //Initialize entity
            Rabbit rabbit = new Rabbit("Fluffy", "Blanc de Hotot");

            //Print Rabbit
            Console.WriteLine(rabbit); //Rabbit (Blanc de Hotot): Fluffy

            //Add Rabbit
            cage.AddRabbit(rabbit);
            Console.WriteLine(cage.Count); 
            cage.RemoveRabbit("Rabbit Name"); //false
            Console.WriteLine(cage.RemoveRabbit("Rabbit Name"));
            Rabbit secondRabbit = new Rabbit("Bunny", "Brazilian");
            Rabbit thirdRabbit = new Rabbit("Jumpy", "Cashmere Lop");
            Rabbit fourthRabbit = new Rabbit("Puffy", "Cashmere Lop");
            Rabbit fifthRabbit = new Rabbit("Marlin", "Brazilian");

            //Add Rabbits
            cage.AddRabbit(secondRabbit);
            cage.AddRabbit(thirdRabbit);
            cage.AddRabbit(fourthRabbit);
            cage.AddRabbit(fifthRabbit);

            //Sell Rabbit by name
            Console.WriteLine(cage.SellRabbit("Bunny")); //Rabbit (Brazilian): Bunny
                                                         //Sell Rabbit by species
            Rabbit[] soldSpecies = cage.SellRabbitsBySpecies("Cashmere Lop");
            Console.WriteLine(string.Join(", ", soldSpecies.Select(f => f.Name))); //Jumpy, Puffy

            Console.WriteLine(cage.Report());
        }
    }
}
