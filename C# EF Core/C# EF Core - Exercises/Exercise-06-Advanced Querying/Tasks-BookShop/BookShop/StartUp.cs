namespace BookShop
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();

            string result = GetMostRecentBooks(db);
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

        // Task - Author Search
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context
                .Authors
                .AsEnumerable()
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => new { FullName = a.FirstName + " " + a.LastName })
                .OrderBy(a => a.FullName)
                .ToList();

            var sb = new StringBuilder();

            foreach (var author in authors)
            {
                sb.AppendLine(author.FullName);
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Book Search
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context
                .Books
                .AsEnumerable()
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => new { b.Title })
                .OrderBy(b => b.Title)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Book Search By Author
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context
                .Books
                .Include("Author")
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(b => new
                {
                    BookId = b.BookId,
                    BookTitle = b.Title,
                    AuthorFullName = b.Author.FirstName + " " + b.Author.LastName
                })
                .OrderBy(b => b.BookId)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.BookTitle} ({book.AuthorFullName})");
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Count Books
        public static string CountBooks(BookShopContext context, int lengthCheck)
        {
            int booksCount = context
                .Books
                .Where(b => b.Title.Length > lengthCheck)
                .Select(b => new
                {
                    BookId = b.BookId,
                })
                .Count();

            var sb = new StringBuilder();

            sb.AppendLine($"{booksCount}");

            return sb.ToString().TrimEnd();
        }

        // Task - Books Copies for Each Author
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authorCopies = context
                .Authors
                .Select(a => new
                {
                    FullName = a.FirstName + " " + a.LastName,
                    BooksCopies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.BooksCopies)
                .ToList();

            var sb = new StringBuilder();

            foreach (var item in authorCopies)
            {
                sb.AppendLine($"{item.FullName} - {item.BooksCopies}");
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Profit by Category
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categoryProfits = context
                .Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    CategoryProfit = c.CategoryBooks.Select(cb => cb.Book.Copies * cb.Book.Price).Sum()
                })
                .OrderByDescending(c => c.CategoryProfit)
                .ThenBy(c => c.CategoryName)
                .ToList();

            var sb = new StringBuilder();

            foreach (var item in categoryProfits)
            {
                sb.AppendLine($"{item.CategoryName} ${item.CategoryProfit}");
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Most Recent Books
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categoryRecentBooks = context
                .Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Books = c.CategoryBooks.Select(cb => new
                    {
                        BookTitle = cb.Book.Title,
                        ReleaseDateYear = cb.Book.ReleaseDate.Value.Year
                    })
                        .OrderByDescending(cb => cb.ReleaseDateYear)
                        .Take(3)
                        .ToList()
                })
                .OrderBy(c => c.CategoryName)
                .ToList();

            var sb = new StringBuilder();

            foreach (var item in categoryRecentBooks)
            {
                sb.AppendLine($"--{item.CategoryName}");
                foreach (var book in item.Books)
                {
                    sb.AppendLine($"{book.BookTitle} ({book.ReleaseDateYear})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        // Task - Increase Prices
        public static void IncreasePrices(BookShopContext context)
        {
            var books = context
                .Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList();

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        // Task - Remove Books
        public static int RemoveBooks(BookShopContext context)
        {
            var books = context
                .Books
                .Where(b => b.Copies < 4200)
                .ToList();

            context.Books.RemoveRange(books);
            context.SaveChanges();

            return books.Count;
        }

    }
}
