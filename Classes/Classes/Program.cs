using Classes.Math;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person niko = new Person();
            niko.Name = "Niko Bellic";
            niko.Introduce("Vlad");

            var roman = new Person()
            {
                Name = "Roman Bellic"
            };
            roman.Introduce("Niko");

            var myName = Person.Parse("Niko Bellic");
            myName.Introduce("Roman");
        }
    }
}
