namespace ExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", "Peshev", 24);
            Person noName = new Person(string.Empty, "Ivanov", 32);
            Person negativAge = new Person("Spas", "Mitov", -1);
        }
    }
}
