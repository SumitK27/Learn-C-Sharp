namespace Dynamics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = true;

            Console.WriteLine($"GetHashCode: {obj.GetHashCode()}");

            // Reflection
            var methodInfo = obj.GetType().GetMethod("GetHashCode");

            var result = methodInfo.Invoke(obj, null);
            Console.WriteLine($"Reflection: {result}");

            // Dynamic
            dynamic dynamicObj = "Niko Bellic";
            Console.WriteLine($"Dynamic: {dynamicObj.Replace("Niko", "Roman")}");

            dynamicObj = 10;
            Console.WriteLine($"Dynamic: {dynamicObj}");

            dynamic num1 = 10;
            dynamic num2 = 5;
            var sum = num1 + num2; // sum is dynamic
            int sumNum = num1 + num2; // sumNum is int

            Console.WriteLine($"Dynamic: {sum}");
            Console.WriteLine($"Dynamic: {sumNum}");
        }
    }
}
