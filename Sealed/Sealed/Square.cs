namespace Sealed
{
    public class Square : Shape
    {
        public double Side { get; set; }

        // The Area method is sealed, so it cannot be overridden in derived classes.
        public sealed override double Area()
        {
            return Side * Side;
        }
    }
}
