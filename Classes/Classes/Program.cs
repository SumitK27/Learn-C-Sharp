using Classes.Math;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the class
            Person niko = new Person();
            niko.Name = "Niko Bellic";
            niko.Introduce("Vlad");

            // Object initializer. Creates a new instance of the class and sets the properties
            var roman = new Person()
            {
                Name = "Roman Bellic"
            };
            roman.Introduce("Niko");

            var myName = Person.Parse("Niko Bellic");
            myName.Introduce("Roman");

            var customer = new Customer();
            Console.WriteLine($"Customer ID: {customer.Id}");
            Console.WriteLine($"Customer Name: {customer.Name}");

            // Create a new instance of the class and set the properties using the constructor
            var customer2 = new Customer("Niko Bellic");
            Console.WriteLine($"Customer ID: {customer2.Id}");
            Console.WriteLine($"Customer Name: {customer2.Name}");

            var customer3 = new Customer(2, "Roman Bellic");
            var order = new Order();
            customer3.Orders.Add(order);
            Console.WriteLine($"Customer ID: {customer3.Id}");
            Console.WriteLine($"Customer Name: {customer3.Name}");
        }
    }
}
