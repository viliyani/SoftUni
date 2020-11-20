using System;

namespace PersonInfo
{
    public class Rebel : IBuyer
    {
        private int food;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public int Food
        {
            get
            {
                return food;
            }
            private set
            {
                food = value;
            }
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
