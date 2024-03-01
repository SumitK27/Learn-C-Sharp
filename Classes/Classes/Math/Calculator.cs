using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Math
{
    public class Calculator
    {
        // Field initializer and readonly field
        readonly static float PI = 3.14f;
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static int Sum(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static void Sum(int[] numbers, out int result)
        {
            result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
        }

        public static float AreaOfCircle(float radius)
        {
            return PI * radius * radius;
        }
    }
}
