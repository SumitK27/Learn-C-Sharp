﻿namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Niko";
            string lastName = "Bellic";

            // Concatenation
            string name = firstName + " " + lastName;
            System.Console.WriteLine(name);
            Console.WriteLine("My name is " + name + " and I'm from Liberty City.");

            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);

            // Interpolation
            string fullName2 = $"{firstName} {lastName}";
            Console.WriteLine(fullName2);

            // Formatting
            string fullName3 = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(fullName3);

            // Joining
            string[] names = { "Niko", "Roman", "Vlad" };
            string result = string.Join(", ", names);
            Console.WriteLine(result);

            // Verbatim
            string path = "C:\\Program Files\\Microsoft";
            Console.WriteLine(path);

            string path2 = @"Path wiht multi-line string
C:\Program Files\Microsoft";
            Console.WriteLine(path2);

            // Escaping
            string text = "The \"quick\" brown fox";
            Console.WriteLine(text);
            Console.WriteLine(
                "C:\\Program Files\\Microsoft\n" +
                "C:\\Program Files\\Microsoft"
            );

            String text2 = "The quick brown fox";
            Console.WriteLine(text2.Length);
        }
    }
}
