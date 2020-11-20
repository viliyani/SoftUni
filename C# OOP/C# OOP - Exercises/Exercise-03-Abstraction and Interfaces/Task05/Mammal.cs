using System;

namespace PersonInfo
{
    public abstract class Mammal : IBirthable
    {
        public Mammal(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
