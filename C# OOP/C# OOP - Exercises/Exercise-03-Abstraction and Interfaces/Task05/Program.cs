using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBirthable> list = new List<IBirthable>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] options = input.Split();

                if (options[0] == "Citizen")
                {
                    string name = options[1];
                    int age = int.Parse(options[2]);
                    string id = options[3];
                    string birthdate = options[4];

                    list.Add(new Citizen(name, age, id, birthdate));
                }
                else if (options[0] == "Pet")
                {
                    string name = options[1];
                    string birthdate = options[2];

                    list.Add(new Cat(name, birthdate));
                }

            }

            string year = Console.ReadLine();

            foreach (var item in list.Where(x => x.Birthdate.EndsWith(year)))
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}
