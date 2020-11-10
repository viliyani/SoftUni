namespace Inheritance
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
