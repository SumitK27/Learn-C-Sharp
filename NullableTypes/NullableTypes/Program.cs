namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable types
            Nullable<int> number = null;

            // Shorter syntax
            DateTime? date = null;

            Console.WriteLine($"GetValueOrDefault(): {date.GetValueOrDefault()}");
            Console.WriteLine($"HasValue: {date.HasValue}");
            //Console.WriteLine($"Value: {date.Value}"); // Throws InvalidOperationException if null

            DateTime? dateValue = new DateTime(2024, 3, 3);
            DateTime dateAssigned = dateValue.GetValueOrDefault();
            DateTime? dateTime = dateAssigned;
            Console.WriteLine($"dateAssigned: {dateAssigned}");
            Console.WriteLine($"dateTime: {dateTime}");

            // Null coalescing operator
            DateTime? dateNull = null;
            DateTime dateNotNull = dateNull ?? DateTime.Today; 
            // Short for dateNull.HasValue ? dateNull.Value : DateTime.Today
            // or dateNull != null ? dateNull.GetValueOrDefault() : DateTime.Today
            Console.WriteLine($"dateNotNull: {dateNotNull}");
        }
    }
}
