namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetName("Niko");
            person.SetBirthdate(new DateTime(1990, 1, 1));
            Console.WriteLine($"Name: {person.GetName()}");
            Console.WriteLine($"Birthdate: {person.GetBirthdate()}");
        }
    }
}
