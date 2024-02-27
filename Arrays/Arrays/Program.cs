namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare an array of integers
            int[] numberArray = new int[5];

            // Initialize the array
            numberArray[0] = 1;
            numberArray[1] = 2;
            numberArray[2] = 3;

            // Access the elements of the array
            Console.WriteLine(numberArray[0]);
            Console.WriteLine(numberArray[3]); // Set to 0 by default

            // Declare and initialize an array
            string[] stringArray = new string[3] { "First", "Second", "Third" };
            Console.WriteLine(stringArray[0]);

            // Change the value of an element
            stringArray[2] = "Last";
            Console.WriteLine(stringArray[2]);
        }
    }
}
