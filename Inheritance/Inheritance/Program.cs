namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 200;
            text.Height = 100;
            text.FontSize = 12;
            text.FontName = "Arial";
            text.Copy();
            text.Duplicate();
            text.AddHyperlink("http://www.google.com");
        }
    }
}
