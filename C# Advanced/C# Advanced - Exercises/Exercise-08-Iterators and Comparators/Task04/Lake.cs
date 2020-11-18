using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> numbers;

        public Lake(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < numbers.Count; i += 2)
            {
                yield return numbers[i];
            }

            for (int i = numbers.Count - 1; i >= 1; i--)
            {
                if (i % 2 != 0)
                {
                    yield return numbers[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
