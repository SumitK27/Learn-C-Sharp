using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class ReverseStringExample
    {
        public static void ReverseYourName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name reversed is: " + ReverseString(name));
        }
        public static string ReverseString(string text)
        {
            return new string(text.Reverse().ToArray());
        }
    }
}
