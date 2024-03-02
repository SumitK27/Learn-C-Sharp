namespace MethodOverriding
{
    public class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
            // Call the base class method
            base.Draw();
        }
    }

    public class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Triangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // Base method that can be overridden by derived classes
        public virtual void Draw()
        {
            Console.WriteLine("Draw a shape");
        }
    }
}
