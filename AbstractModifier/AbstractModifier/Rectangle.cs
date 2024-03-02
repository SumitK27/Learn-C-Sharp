namespace AbstractModifier
{
    public class Rectangle : Shape
    {
        public override Position Position { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}
