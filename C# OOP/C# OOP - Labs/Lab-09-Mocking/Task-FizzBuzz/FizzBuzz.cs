using FizzBuzz.Contracts;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private IWriter writer;

        public FizzBuzz(IWriter writer)
        {
            this.writer = writer;
        }

        public void PrintNumbers(int from, int to)
        {
            if (from <= 0)
            {
                from = 1;
            }

            for (int i = from; i <= to; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    writer.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    writer.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    writer.WriteLine("buzz");
                }
                else
                {
                    writer.WriteLine(i.ToString());
                }
            }



        }

    }
}
