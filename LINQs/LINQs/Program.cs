namespace LINQs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * LINQ: Language Integrated Query
             * Allows to query objects natively in C#
             * Can query:
             * - Objects in memory (Arrays, Lists, etc.)
             * - Databases (Entities, SQL, etc.)
             * - XML
             * - ADO.NET DataSets
             */

            Console.WriteLine("------------ LINQ Extension Methods -------------");
            var books = new BookRepository().GetBooks();
            var cheaperBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Price);
            Print.PrintBooks(cheaperBooks);


            Console.WriteLine("\n");
            var cheaperBookNames = books
                                    .Where(b => b.Price < 10)
                                    .OrderBy(b => b.Price)
                                    .Select(b => b.Title);
            Print.PrintBookNames(cheaperBookNames);

            Console.WriteLine("\n");
            Console.WriteLine("-------------- LINQ Query Operators --------------");
            // Always starts with 'from' and ends with 'select'
            var cheaperBooksQuery = from b in books
                                    where b.Price < 10
                                    orderby b.Price
                                    select b;
            Print.PrintBooks(cheaperBooksQuery);

            Console.WriteLine("\n");
            Console.WriteLine("-------------- LINQ Extension Methods --------------");
            // Single - Expects to have only one element in the sequence that matches the condition
            Console.WriteLine("\n==> Single");
            var singleBook = books.Single(b => b.Title == "ASP.NET MVC");
            Print.PrintBook(singleBook);

            // SingleOrDefault - Expects to have only one element in the sequence that matches the condition
            // If there is no element that matches the condition, it will return the default value of the type
            Console.WriteLine("\n==> SingleOrDefault");
            var singleOrDefaultBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            Print.PrintBookOrNotFound(singleOrDefaultBook);

            // First - Returns the first element in the sequence
            // Optionally, it can take a condition to return the first element that matches the condition
            Console.WriteLine("\n==> First");
            var firstBook = books.First();
            Print.PrintBook(firstBook);

            var firstBookWithCondition = books.First(b => b.Title == "C# Advanced Topics");
            Print.PrintBook(firstBookWithCondition);

            // FirstOrDefault - Returns the first element in the sequence that matches the condition
            // If there is no element that matches the condition, it will return the default value of the type
            Console.WriteLine("\n==> FirstOrDefault");
            var firstOrDefaultBook = books.FirstOrDefault(b => b.Title == "C# Advanced Topics++");
            Print.PrintBookOrNotFound(firstOrDefaultBook);

            // Last - Returns the last element in the sequence
            // Optionally, it can take a condition to return the last element that matches the condition
            Console.WriteLine("\n==> Last");
            var lastBook = books.Last();
            Print.PrintBook(lastBook);

            var lastBookWithCondition = books.Last(b => b.Title == "C# Advanced Topics");
            Print.PrintBook(lastBookWithCondition);

            // LastOrDefault - Returns the last element in the sequence that matches the condition
            // If there is no element that matches the condition, it will return the default value of the type
            Console.WriteLine("\n==> LastOrDefault");
            var lastOrDefaultBook = books.LastOrDefault(b => b.Title == "C# Advanced Topics++");
            Print.PrintBookOrNotFound(lastOrDefaultBook);

            // Skip - Skips the first n elements in the sequence
            Console.WriteLine("\n==> Skip");
            var skipBooks = books.Skip(2);
            Print.PrintBooks(skipBooks);

            // Take - Takes the first n elements in the sequence
            Console.WriteLine("\n==> Take");
            var takeBooks = books.Take(2);
            Print.PrintBooks(takeBooks);

            var pagedBooks = books.Skip(3).Take(3);
            Console.WriteLine("\n==> Skip and Take");
            Print.PrintBooks(pagedBooks);

            // Count - Returns the number of elements in the sequence
            Console.WriteLine("\n==> Count");
            var countBooks = books.Count();
            Console.WriteLine($"Total books: {countBooks}");

            // Max - Returns the maximum value in the sequence
            Console.WriteLine("\n==> Max");
            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine($"Max price: ${maxPrice}");

            // Min - Returns the minimum value in the sequence
            Console.WriteLine("\n==> Min");
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine($"Min price: ${minPrice}");

            // Sum - Returns the sum of the values in the sequence
            Console.WriteLine("\n==> Sum");
            var sumPrice = books.Sum(b => b.Price);
            Console.WriteLine($"Sum of prices: ${sumPrice}");

            // Average - Returns the average of the values in the sequence
            Console.WriteLine("\n==> Average");
            var averagePrice = books.Average(b => b.Price);
            Console.WriteLine($"Average price: ${averagePrice}");
        }
    }
}
