using System;

namespace Practice
{
    public class Rabbit
    {
        private Rabbit()
        {
            Available = true;
        }

        public Rabbit(string name, string species)
            : this()
        {
            Name = name;
            Species = species;
        }

        public string Name { get; private set; }

        public string Species { get; private set; }

        public bool Available { get; set; }

        public override string ToString()
        {
            return $"Rabbit ({Species}): {Name}";
        }
    }
}
