namespace Constructor
{
    public class Car: Vehicle
    {
        // If a constructor is defined, the compiler will not add a default constructor
        // : base(registrationNumber) is used to call the base class constructor
        // Execute the base class constructor before the derived class constructor
        public Car(string registrationNumber): base(registrationNumber)
        {
            Console.WriteLine($"Car has being initialized. {registrationNumber}");
        }
    }
}
