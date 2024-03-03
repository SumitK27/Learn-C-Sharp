namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Extension methods are a way to add new methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.
             * If you have source code for the original type, you can add the method to the original type.
             * If you don't have the source code for the original type, you can implement it's interface to add the method.
             * If no interface is available, create a extension method.
             * Problem: If you extend a type with a new method and later the original type is updated with a method with the same name, your extension method will be hidden.
             */
            var postDescription = "This is going to be a very long blog post blah blah blah...";
            var shortenedPost = postDescription.Shorten(5);

            Console.WriteLine($"Original Post: {postDescription}");
            Console.WriteLine($"Shortened Post: {shortenedPost}");

            // Using built-in extension methods
            IEnumerable<int> numbers = new List<int> { 7, 2, 9, 3, 5 };
            var max = numbers.Max(); // Max is an extension method in System.Linq namespace
            Console.WriteLine($"Max: {max}");
        }
    }
}
