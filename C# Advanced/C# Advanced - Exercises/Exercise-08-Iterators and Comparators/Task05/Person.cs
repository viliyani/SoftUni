using System;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Name == other.Name)
            {
                if (this.Age == other.Age)
                {
                    return this.Town.CompareTo(other.Town);
                }
                else
                {
                    return this.Age.CompareTo(other.Age);
                }
            }
            else
            {
                return this.Name.CompareTo(other.Name);
            }
        }
    }
}
