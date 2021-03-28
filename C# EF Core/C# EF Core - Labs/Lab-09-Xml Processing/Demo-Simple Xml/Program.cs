using System;
using System.Linq;
using System.Xml.Linq;

namespace XmlDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            XDocument document = XDocument.Load("Data.xml");

            int booksCount = document.Root.Elements().Count();
            Console.WriteLine($"Total books: {booksCount}");

            foreach (var element in document.Root.Elements())
            {
                Console.WriteLine(element.Element("title").Value);
            }

        }
    }
}
