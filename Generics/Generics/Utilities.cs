namespace Generics
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // IComarable adds a constraint to the generic type
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        // new() adds a constraint that the type must have a default constructor
        public T CreateInstance<T>() where T : new()
        {
            return new T();
        }
    }
}
