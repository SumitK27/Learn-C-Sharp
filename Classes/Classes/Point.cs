namespace Classes
{
    internal partial class Program
    {
        public class Point
        {
            public int X;
            public int Y;

            public Point()
            {
                X = 0;
                Y = 0;
            }

            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            // Method overloading
            public void Move(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public void Move(Point newLocation)
            {
                if (newLocation == null)
                    throw new ArgumentNullException("newLocation", "Location cannot be Null");
                Move(newLocation.X, newLocation.Y);
            }

            public void Reset()
            {
                this.X = 0;
                this.Y = 0;
            }
        }
    }
}
