namespace DateTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2024, 02, 29);
            Console.WriteLine(dateTime);

            Console.WriteLine("Current date and time: " + DateTime.Now);
            Console.WriteLine("Current date: " + DateTime.Today);
            Console.WriteLine("Current year: " + DateTime.Now.Year);

            Console.WriteLine("Hour: " + DateTime.Now.Hour);
            Console.WriteLine("Minute: " + DateTime.Now.Minute);

            Console.WriteLine("Yesterday: " + DateTime.Now.AddDays(-1));
            Console.WriteLine("Tomorrow: " + DateTime.Now.AddDays(1));

            Console.WriteLine("Day of the week: " + DateTime.Now.DayOfWeek);

            // Formatting
            Console.WriteLine("Long date: " + DateTime.Now.ToLongDateString());
            Console.WriteLine("Short date: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Long time: " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("Short time: " + DateTime.Now.ToShortTimeString());
            Console.WriteLine("To string: " + DateTime.Now.ToString());
            Console.WriteLine("Custom format: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
        }
    }
}
