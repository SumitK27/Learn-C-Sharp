namespace Constructor
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        // If no constructor is defined, the compiler will add a default constructor with no parameters
        public Vehicle()
        {
            Console.WriteLine("Vehicle has being initialized");
        }

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine($"Vehicle has been initialized. {registrationNumber}");
        }
    }
}
