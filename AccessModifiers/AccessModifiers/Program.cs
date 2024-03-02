using Amazon;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Male");
            person.SetName("Niko");
            Console.WriteLine($"Name: {person.GetName()}");

            person.BirthDate = new DateTime(1990, 1, 1);
            Console.WriteLine($"Birthdate: {person.BirthDate}");
            Console.WriteLine($"Age: {person.Age}");

            person.Place = "Liberty City";
            Console.WriteLine($"Place: {person.Place}");

            // Access Modifier Example
            var customer = new Customer();
            customer.Promote();
        }
    }
}
