using Classes.Math;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person niko = new Person();
            niko.firstName = "Niko";
            niko.lastName = "Bellic";
            niko.Introduce();

            var result = Calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
