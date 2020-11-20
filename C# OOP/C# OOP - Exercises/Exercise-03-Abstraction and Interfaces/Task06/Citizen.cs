using System;

namespace PersonInfo
{
    public class Citizen : Mammal, IIdentifiable, IBuyer
    {
        private int food;

        public Citizen(string name, int age, string id, string birthdate)
            : base(name, birthdate)
        {
            this.Age = age;
            this.Id = id;
        }

        public int Age { get; private set; }

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

        public string Id { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
