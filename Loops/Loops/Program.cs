namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = new[] { 1, 2, 3 };

            // For
            Console.WriteLine("For Loop:");

            for(var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Foreach
            Console.WriteLine("Foreach Loop:");

            foreach(var element in array1)
            {
                Console.WriteLine(element);
            }

            // While
            Console.WriteLine("While Loop:");
            var whileIterator = 0;
            while(whileIterator < 5)
            {
                Console.WriteLine(whileIterator);
                whileIterator++;
            }

            // Do While
            Console.WriteLine("Do While:");
            var doWhileIterator = 0;

            do
            {
                Console.WriteLine(doWhileIterator);
                doWhileIterator++;
            } while(doWhileIterator == 5);

            while(true)
            {
                Console.Write("Enter your name: ");
                var name = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine($"Hello {name}");
                    continue;
                }
                break;
            }
        }
    }
}
