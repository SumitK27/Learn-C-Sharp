using Classes.Math;

namespace Classes
{
    internal partial class Program
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

            Console.WriteLine("--------------------------------------------");
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

            var pointA = new Point(10, 20);
            pointA.Move(40, 60);
            Console.WriteLine($"Point A: {pointA.X}, {pointA.Y}");

            var pointB = new Point(10, 20);
            pointB.Move(new Point(60, 30));
            Console.WriteLine($"Point B: {pointB.X}, {pointB.Y}");

            try
            {
                var pointC = new Point();
                pointC.Move(null);
            } catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Add(1, 2): \t\t\t\t" + Calculator.Add(1, 2));
            Console.WriteLine("Add([1, 2, 3, 4, 5, 6]): \t\t" + Calculator.Add(new int[] { 1, 2, 3, 4, 5, 6 }));
            Console.WriteLine("Sum(1, 2, 3, 4, 5): \t\t\t" + Calculator.Sum(1, 2, 3, 4, 5));
            Calculator.Sum(new int[] { 1, 2, 3, 4, 5 }, out int result);
            Console.WriteLine("Sum([1, 2, 3, 4, 5], out int result): \t" + result);
            Console.WriteLine("AreaOfCircle(5): \t\t\t" + Calculator.AreaOfCircle(5));
        }
    }
}
