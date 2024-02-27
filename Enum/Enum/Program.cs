namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public enum ShippingMethod2 : byte
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public enum Boolean
    {
        False,
        True
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Access enum and its value
            Console.WriteLine($"Shipping Method: {ShippingMethod.Express} which has a value {(int)ShippingMethod.Express}");
            Console.WriteLine($"Boolean: {Boolean.False}");

            // Convert enum to int
            var shipmentMethodId = 3;
            Console.WriteLine((ShippingMethod)shipmentMethodId);

            // Convert enum to string
            var express = ShippingMethod.Express;
            Console.WriteLine(express.ToString());

            // Convert string to enum
            var methodName = "RegisteredAirMail";
            Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(methodName);

            // Convert string to enum (case insensitive)
            var caseInSensitive = "regularairmail";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), caseInSensitive, true);
            Console.WriteLine(shippingMethod);
        }
    }
}
