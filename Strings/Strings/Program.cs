namespace Strings
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

            string mixedCase = "   ThE qUiCk BrOwN fOx    ";
            Console.WriteLine("Original string: " + mixedCase);
            Console.WriteLine("Upper Case: " + mixedCase.ToUpper());
            Console.WriteLine("Lower Case: " + mixedCase.ToLower());
            Console.WriteLine("Trimmed: " + mixedCase.Trim());
            Console.WriteLine("IndexOf o: " + mixedCase.ToLower().IndexOf("o"));
            Console.WriteLine("LastIndexOf o: " + mixedCase.ToLower().LastIndexOf("o"));
            Console.WriteLine("Substring: " + mixedCase.Substring(4, 10));
            Console.WriteLine("Replace: " + mixedCase.ToLower().Replace("fox", "dog"));

            string[] words = mixedCase.Split(" ");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            string empty = " ";
            Console.WriteLine(string.IsNullOrEmpty(empty));
            Console.WriteLine(string.IsNullOrWhiteSpace(empty));

            string numberString = "123";
            Console.WriteLine("Number string: " + numberString);
            Console.WriteLine("Type: " + numberString.GetType());
            
            // May throw an exception if the string is not a number or is null
            Console.WriteLine("Parse: " + int.Parse(numberString)); 
            Console.WriteLine("Convert.ToInt32: " + Convert.ToInt32(numberString));

            // Will not throw an exception if the string is not a number or is null
            string emptyString = "";
            int.TryParse(emptyString, out int parsedNumber);
            Console.WriteLine("TryParse: " + parsedNumber);

            // Number to string
            int number = 123456;
            Console.WriteLine("Number: " + number);
            Console.WriteLine("ToString: " + number.ToString());
            Console.WriteLine("ToString with format: " + number.ToString("N0"));
            Console.WriteLine("ToString with format: " + number.ToString("N2"));
            Console.WriteLine("ToString with format: " + number.ToString("C0"));

            // Format string
            Console.WriteLine("Formatted (Decimal): " + number.ToString("d"));
            Console.WriteLine("Formatted (Exponential): " + number.ToString("e"));
            Console.WriteLine("Formatted (Fixed): " + number.ToString("f"));
            Console.WriteLine("Formatted (Hex): " + number.ToString("x"));

        }
    }
}
