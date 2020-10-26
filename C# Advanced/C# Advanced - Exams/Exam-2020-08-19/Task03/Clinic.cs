using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;

        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        public Clinic(int capacity)
        {
            data = new List<Pet>();
            Capacity = capacity;
        }

        public void Add(Pet pet)
        {
            if (Count < Capacity)
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            if (data.Exists(x => x.Name == name))
            {
                data.Remove(data.Find(x => x.Name == name));
                return true;
            }
            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            if (data.Exists(x => x.Name == name && x.Owner == owner))
            {
                return data.Find(x => x.Name == name && x.Owner == owner);
            }
            return null;
        }

        public Pet GetOldestPet()
        {
            if (Count > 0)
            {
                return data.OrderByDescending(x => x.Age).FirstOrDefault();
            }
            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("The clinic has the following patients:");
            sb.Append(Environment.NewLine);

            for (int i = 0; i < Count; i++)
            {
                sb.Append($"Pet {data[i].Name} with owner: {data[i].Owner}");
                if (i != Count - 1)
                {
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }
    }
}
