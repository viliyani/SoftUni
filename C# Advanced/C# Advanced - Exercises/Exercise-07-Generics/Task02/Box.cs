namespace GenericsExercise
{
    public class Box<T>
    {
        private T data;

        public Box(T data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return $"{this.data.GetType()} {this.data}";
        }

    }
}
