using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            int check = x.Title.CompareTo(y);

            if (check < 0)
            {
                return -1;
            }
            else if (check > 0)
            {
                return 1;
            }
            else
            {
                return x.Year - y.Year;
            }
        }
    }
}
