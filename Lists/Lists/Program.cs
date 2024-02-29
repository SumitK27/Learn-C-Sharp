using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Add one item
            numbers.Add(6);

            // Add a range of items
            numbers.AddRange(new int[3] { 7, 8, 9 });

            Console.WriteLine("After adding elements: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // IndexOf and LastIndexOf
            numbers.Add(1);
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            // Count
            Console.WriteLine("Count: " + numbers.Count);

            // Remove
            numbers.Remove(1);
            Console.WriteLine("After removing first element that matches 1");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);

            Console.WriteLine("Count: " + numbers.Count);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Remove all
            numbers.RemoveAll(n => n == 1);

            Console.WriteLine("After removing all 1's");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Remove at
            numbers.RemoveAt(0);
            Console.WriteLine("Count: " + numbers.Count);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Clear
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
