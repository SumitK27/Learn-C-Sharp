namespace Sealed
{
    // The Circle class is sealed, so it cannot be inherited from.
    public sealed class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
