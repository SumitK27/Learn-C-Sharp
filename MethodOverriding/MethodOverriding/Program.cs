namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            // Can add any class that derives from Shape
            shapes.Add(new Circle()
            {
                Width = 100,
                Height = 100,
            });
            shapes.Add(new Rectangle()
            {
                Width = 60,
                Height = 40,
            });

            var canvas = new Canvas();
            canvas.DrawShape(shapes);
        }
    }
}
