using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    public class Cage
    {
        private readonly List<Rabbit> data;

        private Cage()
        {
            data = new List<Rabbit>();
        }

        public Cage(string name, int capacity)
            : this()
        {
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int Count => data.Count;

        public void AddRabbit(Rabbit rabbit)
        {
            if (data.Count + 1 <= Capacity)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Name == name);

            if (rabbit != null)
            {
                data.Remove(rabbit);

                return true;
            }

            return false;
        }

        public void RemoveSpecies(string species)
        {
            data.RemoveAll(r => r.Species == species);
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Name == name);

            if (rabbit != null)
            {
                rabbit.Available = false;
            }

            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbits = data.Where(r => r.Species == species).ToArray();

            foreach (var rabbit in rabbits)
            {
                rabbit.Available = false;
            }

            return rabbits;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at {Name}:");

            foreach (var rabbit in data.Where(r => r.Available))
            {
                sb.AppendLine(rabbit.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
