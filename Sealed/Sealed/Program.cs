namespace Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Sealed:
             *  A sealed class cannot be inherited from.
             *  You can also seal a method in a class that is not sealed.
             *  Sealed methods cannot be overridden in derived classes.
             *  Sealed classes are slightly faster than unsealed classes due to the fact that the runtime does not have to check for derived classes.
             */
            var circle = new Circle { Radius = 2 };
            Console.WriteLine($"Circle area: {circle.Area()}");

            var square = new Square { Side = 2 };
            Console.WriteLine($"Square area: {square.Area()}");
        }
    }
}
