using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBuyer> list = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split();

                if (options.Length == 4)
                {
                    string name = options[0];
                    int age = int.Parse(options[1]);
                    string id = options[2];
                    string birthdate = options[3];

                    list.Add(new Citizen(name, age, id, birthdate));
                }
                else if (options.Length == 3)
                {
                    string name = options[0];
                    int age = int.Parse(options[1]);
                    string group = options[2];

                    list.Add(new Rebel(name, age, group));
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (list.Any(x => x.Name == input))
                {
                    list.Find(x => x.Name == input).BuyFood();
                }

            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} - {item.Food}");
            }
        }
    }
}
