namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Delegate is a type that represents references to methods with a particular parameter list and return type.
             * Used to pass methods as arguments to other methods as a callback.
             * Used for making code extensible and flexible.
             * There are few built-in delegates in C#:
             * - Action: points to a method that takes parameters and returns void.
             * - Func: points to a method that takes parameters and returns a value.
             * Alternative to delegate is Interface.
             */
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;
            processor.Process("image.png", filterHandler);

            var processor2 = new PhotoProcessor();
            Action<Photo> filterHandler2 = filters.ApplyBrightness;
            filterHandler2 += filters.ApplyContrast;
            filterHandler2 += RemoveRedEye;
            processor2.Process("image.png", filterHandler2);
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Removing red eye...");
        }
    }
}
