namespace AbstractModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Abstract Modifier:
             *  Abstract members are implicitly virtual
             *  Abstract members cannot have a body
             *  If a class contains abstract members, the class must be declared as abstract
             *  Must impletemt all abstract members in the base abstract class
             *  Abstract class cannot be instantiated
             */

            var circle = new Circle();
            circle.Draw();
            circle.Copy();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
