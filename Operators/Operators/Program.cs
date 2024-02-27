namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = 10;
            int numTwo = 2;
            int numThree = 3;

            // Arithmetic operators
            int result = numOne + numTwo;
            System.Console.WriteLine(result);

            result = numOne - numTwo;
            System.Console.WriteLine(result);

            result = numOne * numTwo;
            System.Console.WriteLine(result);

            result = numOne / numTwo;
            System.Console.WriteLine(result);

            // Operator precedence
            result = numOne + numTwo * numThree;
            System.Console.WriteLine(result);

            result = (numOne + numTwo) * numThree;
            System.Console.WriteLine(result);

            // Comparison operators
            bool isEqual = numOne == numTwo;
            System.Console.WriteLine(isEqual);

            bool isNotEqual = numOne != numTwo;
            System.Console.WriteLine(isNotEqual);

            bool isGreater = numOne > numTwo;
            System.Console.WriteLine(isGreater);

            bool isLess = numOne < numTwo;
            System.Console.WriteLine(isLess);

            bool isGreaterOrEqual = numOne >= numTwo;
            System.Console.WriteLine(isGreaterOrEqual);

            bool isLessOrEqual = numOne <= numTwo;
            System.Console.WriteLine(isLessOrEqual);

            // Logical operators
            bool isTrue = true;
            bool isFalse = false;

            bool andResult = isTrue && isFalse;
            System.Console.WriteLine(andResult);

            bool orResult = isTrue || isFalse;
            System.Console.WriteLine(orResult);

            bool notResult = !isTrue;
            System.Console.WriteLine(notResult);
        }
    }
}
