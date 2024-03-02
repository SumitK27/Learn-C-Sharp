namespace AbstractModifier
{
    public class Circle : Shape
    {
        public override Position Position { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}
