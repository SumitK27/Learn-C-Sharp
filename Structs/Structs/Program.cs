namespace Structs
{
    // A struct is a value type that is typically used to encapsulate small groups of related variables.
    public struct Point
    {
        public int X;
        public int Y;

        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Point object and assign it some values
            Point p = new Point();
            p.X = 10;
            p.Y = 20;
            p.Print();
        }
    }
}
