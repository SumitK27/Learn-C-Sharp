namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();

            // Set and get the value by using the indexer
            cookie["name"] = "Niko";
            Console.WriteLine(cookie["name"]);

            // Set and get the value by using GetItem and SetItem
            cookie.SetItem("name", "Niko");
            Console.WriteLine(cookie.GetItem("name"));
        }
    }
}
