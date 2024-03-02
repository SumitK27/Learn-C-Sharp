namespace UpAndDownCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            // Upcasting - implicit - Converts derived class to base class
            Shape shape = text;
            Shape shape1 = new Text();

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine("Text width: " + text.Width);

            // StreamReader takes a Stream object as a parameter and MemoryStream is a derived class of Stream class.
            // This is an example of upcasting
            StreamReader reader = new StreamReader(new MemoryStream());

            // Downcasting - explicit - Converts base class to derived class
            // May throw InvalidCastException if the conversion is not possible
            Text anotherText = (Text) shape;

            // Another way to downcast
            Text anotherText1 = shape as Text;
            if (anotherText1 != null)
            {
                Console.WriteLine("Text width: " + anotherText1.Width);
            }

            // is operator
            if (shape is Text)
            {
                Text anotherText2 = (Text) shape;
                Console.WriteLine("Text width: " + anotherText2.Width);
            }
        }
    }
}
