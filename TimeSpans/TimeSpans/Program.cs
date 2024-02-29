namespace TimeSpans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);

            Console.WriteLine(TimeSpan.FromHours(1) + TimeSpan.FromMinutes(2) + TimeSpan.FromSeconds(3));

            // Difference between two dates
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddDays(3).AddHours(10).AddMinutes(2);
            TimeSpan duration = end - start;
            Console.WriteLine(duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes); // 2
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // 62.05 (1 hour + 2 minutes + 3 seconds)
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // 01:10:03

            // Add Example
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // 01:10:03

            // Subtract Example
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2))); // 01:00:03

            // ToString
            Console.WriteLine("ToString: " + timeSpan.ToString()); // 01:02:03
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03")); // 01:02:03
        }
    }
}
