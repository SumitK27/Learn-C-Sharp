namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicitly typed variables
            byte number = 2;
            int count = 10;
            float totalPrice = 12.34f;
            char character = 'S';
            string firstName = "Niko";
            bool isWorking = true;

            // Explicitly typed variables
            var anotherNumber = 3;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(anotherNumber);

            // Format strings
            Console.WriteLine("Byte: Min {0} Max {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Float: Min {0} Max {1}", float.MinValue, float.MaxValue);

            // Constants
            const float Pi = 3.14f;
            Console.WriteLine(Pi);
        }
    }
}
