namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Generic classes and methods enable you to define classes and methods with placeholders for the data type.
             * Here are some benefits of using generics:
             *  - Reusability: You can use the same generic class with different data types.
             *  - Type safety: You can catch type mismatches at compile time.
             *  - Performance: Generics can provide better performance by removing the overhead of boxing and unboxing.
             *  - Code maintainability: You can maintain a single code base for different data types.
             *  - Readability: You can write more readable and maintainable code.
             * Constraints: 
             *  - Limits the types that can be used as arguments
             *  - Can be of type: class (reference type), interface, struct (value type), or new()
             */
            var utilities = new Utilities();
            Console.WriteLine("-------------------- Generics --------------------");
            Console.WriteLine($"Max (w/o Generics): {utilities.Max(1, 2)}");
            Console.WriteLine($"Max (w/ Generics int): {utilities.Max<int>(1, 2)}");
            Console.WriteLine($"Max (w/ Generics char): {utilities.Max<char>('a', 'b')}");

            var arithmeticInt = new Arithmetic<int>();
            Console.WriteLine($"-------------------- Generics (int) --------------------");
            Console.WriteLine($"Add (w/ Generics): {arithmeticInt.Add(1, 2)}");
            Console.WriteLine($"Subtract (w/ Generics): {arithmeticInt.Subtract(1, 2)}");
            Console.WriteLine($"Multiply (w/ Generics): {arithmeticInt.Multiply(1, 2)}");
            Console.WriteLine($"Divide (w/ Generics): {arithmeticInt.Divide(1, 2)}");

            var arithmeticFloat = new Arithmetic<float>();
            Console.WriteLine($"-------------------- Generics (float) --------------------");
            Console.WriteLine($"Add (w/ Generics): {arithmeticFloat.Add(1.1f, 2.2f)}");
            Console.WriteLine($"Subtract (w/ Generics): {arithmeticFloat.Subtract(1.1f, 2.2f)}");
            Console.WriteLine($"Multiply (w/ Generics): {arithmeticFloat.Multiply(1.1f, 2.2f)}");
            Console.WriteLine($"Divide (w/ Generics): {arithmeticFloat.Divide(1.1f, 2.2f)}");

            var number = new Nullable<int>(5);
            Console.WriteLine($"-------------------- Generics (Nullable) --------------------");
            Console.WriteLine($"HasValue: {number.HasValue}");
            Console.WriteLine($"GetValueOrDefault: {number.GetValueOrDefault()}");

            var number2 = new Nullable<int>();
            Console.WriteLine($"HasValue: {number2.HasValue}");
            Console.WriteLine($"GetValueOrDefault: {number2.GetValueOrDefault()}");

            var product = new Product();
            Console.WriteLine($"-------------------- Generics (Product) --------------------");
            product.Title = "Book";
            product.Price = 9.99f;
            var discountCalculator = new DiscountCalculator<Product>();
            Console.WriteLine($"CalculateDiscount: {discountCalculator.CalculateDiscount(product)}");

            utilities.CreateInstance<Product>();
        }
    }
}
