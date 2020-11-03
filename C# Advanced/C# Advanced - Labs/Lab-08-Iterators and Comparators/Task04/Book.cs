using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public int CompareTo(Book other)
        {
            if (this.Year == other.Year)
            {
                int check = this.Title.CompareTo(other.Title);
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
                    return 0;
                }
            }
            else if (this.Year < other.Year)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
