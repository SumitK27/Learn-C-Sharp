namespace LambdaExpressions
{
    internal class Program
    {
        /*
         * Lambda expressions are a concise way to represent an anonymous method.
         * It has no name, no return statement, and no access modifier.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Without Lambda Expressions -----------");
            var numberToSquare = 5;
            Console.WriteLine($"Square({numberToSquare}): {Square(numberToSquare)}");

            Console.WriteLine("----------- With Lambda Expressions -----------");
            var square = new Func<int, int>(number => number * number);
            Console.WriteLine($"Square({numberToSquare}): {square(numberToSquare)}"); 

            Func<int, int> square2 = number => number * number;
            Console.WriteLine($"Square({numberToSquare}): {square2(numberToSquare)}");

            var numberToMultiply = 10;
            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine($"Multiplier({numberToMultiply}): {multiplier(numberToMultiply)}");

            Console.WriteLine("----------- Using Lambda Expressions with Predicate -----------");
            var bookRepository = new BookRepository();
            var books = bookRepository.GetBooks();
            var cheapBooksPredicate = books.FindAll(IsCheaperThan10Dollars);
            foreach (var book in cheapBooksPredicate)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("----------- Using Lambda Expressions with LINQ -----------");
            var cheapBooks = books.FindAll(book => book.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static int Square(int number)
        {
            return number * number;
        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
