using System;
using System.Linq;

namespace UnitTesting
{
    public class ExtendedDatabase
    {
        private Person[] persons;

        private int count;

        public ExtendedDatabase(params Person[] persons)
        {
            this.Persons = new Person[16];
            AddRange(persons);
        }

        public int Count
        {
            get { return count; }
        }

        public Person[] Persons
        {
            get
            {
                return persons;
            }

            set
            {
                persons = value;
            }
        }

        private void AddRange(Person[] data)
        {
            if (data.Length > 16)
            {
                throw new ArgumentException("Provided data length should be in range [0..16]!");
            }

            for (int i = 0; i < data.Length; i++)
            {
                this.Add(data[i]);
            }

            this.count = data.Length;
        }

        public void Add(Person person)
        {
            if (this.count == 16)
            {
                throw new InvalidOperationException("Array's capacity must be exactly 16 integers!");
            }

            if (Persons.Any(p => p?.UserName == person.UserName))
            {
                throw new InvalidOperationException("There is already user with this username!");
            }

            if (Persons.Any(p => p?.Id == person.Id))
            {
                throw new InvalidOperationException("There is already user with this Id!");
            }

            this.Persons[this.count] = person;
            this.count++;
        }

        public void Remove()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException();
            }

            this.count--;
            this.Persons[this.count] = null;
        }

        public Person FindByUsername(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Username parameter is null!");
            }

            if (this.Persons.Any(p => p?.UserName == name) == false)
            {
                throw new InvalidOperationException("No user is present by this username!");
            }

            Person person = this.Persons.First(p => p.UserName == name);
            return person;
        }


        public Person FindById(long id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Id should be a positive number!");
            }

            if (this.Persons.Any(p => p?.Id == id) == false)
            {
                throw new InvalidOperationException("No user is present by this ID!");
            }

            Person person = this.Persons.First(p => p.Id == id);
            return person;
        }

    }
}
