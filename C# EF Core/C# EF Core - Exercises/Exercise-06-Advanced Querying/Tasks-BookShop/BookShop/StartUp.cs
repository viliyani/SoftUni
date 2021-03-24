namespace BookShop
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();

            string result = GetBooksReleasedBefore(db, "12-04-1992");
            Console.WriteLine(result);
        }

        // Task - Books by Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var books = context
                .Books
                .AsEnumerable()
                .Where(x => x.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(x => new { x.Title })
                .OrderBy(x => x.Title)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Golden Books
        public static string GetGoldenBooks(BookShopContext context)
        {
            var books = context
                .Books
                .AsEnumerable()
                .Where(b => b.EditionType == Enum.Parse<EditionType>("Gold") && b.Copies < 5000)
                .Select(b => new { b.Title, b.BookId })
                .OrderBy(b => b.BookId)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Books By Price
        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context
                .Books
                .AsEnumerable()
                .Where(b => b.Price > 40)
                .Select(b => new { b.Title, b.Price })
                .OrderByDescending(b => b.Price)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Not Released In
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context
                .Books
                .AsEnumerable()
                .Where(b => b.ReleaseDate.Value.Year != year)
                .Select(b => new { b.Title, b.BookId })
                .OrderBy(b => b.BookId)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title}");
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Book Titles By Category
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var books = context
                .Books
                .AsEnumerable()
                .Where(b => b.BookCategories.Any(bc => categories.Contains(bc.Category.Name.ToLower())))
                .Select(b => new { b.Title })
                .OrderBy(b => b.Title)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title}");
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Released Before Date
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var datetime = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context
                .Books
                .AsEnumerable()
                .Where(b => b.ReleaseDate.Value < datetime)
                .Select(b => new { b.Title, b.EditionType, b.Price, b.ReleaseDate })
                .OrderByDescending(b => b.ReleaseDate)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }



    }
}
