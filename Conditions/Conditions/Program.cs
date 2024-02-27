namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If-else
            int hour = 19;

            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                System.Console.WriteLine("It's afternoon.");
            }
            else
            {
                System.Console.WriteLine("It's evening.");
            }

            // Switch
            var day = DayOfWeek.Friday;
            switch (day)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's a fun day");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Stay alive till tomorrow");
                    break;
                default:
                    Console.WriteLine("It's a work day");
                    break;
            }

            // Ternary
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
        }
    }
}
