using System.Text;

namespace StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            builder.Append("The list of numbers is: ");
            for (var i = 0; i < 10; i++)
            {
                builder.Append(i);
                if (i < 9)
                {
                    builder.Append(", ");
                }
            }

            Console.WriteLine(builder.ToString());
            
            builder.Clear();
            builder.Append('-', 60);
            Console.WriteLine(builder.ToString());
            builder.Clear();

            builder.Append("Header").AppendLine();
            builder.Append('-', 60);
            Console.WriteLine(builder.ToString());

            builder.Clear();
            builder.AppendLine("Hello World!");
            Console.WriteLine(builder.ToString());

            builder.Replace("World", "C#");
            Console.WriteLine(builder.ToString());

            builder.Remove(5, 6);
            Console.WriteLine(builder.ToString());

            builder.Insert(0, "C# says ");
            Console.WriteLine(builder.ToString());

            Console.WriteLine("First char: " + builder.);
        }
    }
}
