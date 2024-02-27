namespace ValueVsReference
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Struct:
             * - Value type
             * - Stored on the stack
             * - Memory allocation is done at the time of declaration
             * - Faster than class
             * - Can't have a null value
             * - Can't inherit from another struct or class
             * - Can't be used as a base for any class
             * - Removed from the stack when it goes out of scope
             * eg. Primitive types, Custom structs
             */
            var point = new Point(10, 20);
            point.Move(10, 20);
            Console.WriteLine(point.ToString());

            /* Class:
             * - Reference type
             * - Stored on the heap
             * - Memory allocation is done at the time of instantiation
             * - Slower than struct
             * - Can have a null value
             * - Can inherit from another class or interface
             * - Can be used as a base for any class
             * - Garbage collected by CLR
             * eg. Strings, Arrays, Custom classes
             */
            var person = new Person("Niko", 35);
            person.SetAge(36);
            Console.WriteLine(person.ToString());

            // Difference between value and reference types
            var a = 10;
            var b = a; // int is value type. Value is copied to b
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1; // array is reference type. Reference is copied to array2
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            // Reference type on Custom class
            var person1 = new Person("Niko", 35);
            var person2 = person1; // person is reference type. Reference is copied to person2
            person2.SetAge(36);
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
