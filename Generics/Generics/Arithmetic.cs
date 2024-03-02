using System.Numerics;

namespace Generics
{
    // Template can also be added to the class itself
    public class Arithmetic<T> where T : INumber<T>
    {
        public T Add(T a, T b)
        {
            return a + b;
        }

        public T Subtract(T a, T b)
        {
            return a - b;
        }

        public T Multiply(T a, T b)
        {
            return a * b;
        }

        public T Divide(T a, T b)
        {
            return a / b;
        }
    }
}
