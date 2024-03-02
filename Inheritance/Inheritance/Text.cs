namespace Inheritance
{
    // Text class inherits from PresentationObject class with is-a relationship
    // Used for tight coupling and code reuse   
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}
