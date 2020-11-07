namespace GenericsExercise
{
    public class Tupple<T, V, P>
    {
        public T Item1 { get; set; }
        public V Item2 { get; set; }
        public P Item3 { get; set; }

        public Tupple(T item1, V item2, P item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
    }
}
