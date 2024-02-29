using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Unique
    {
        public static void UniqieNumber()
        {
            var numbers = new List<int>();
            bool doContinue = true;
            do
            {
                Console.WriteLine("Enter a number or 'Q' to quit: ");
                var input = Console.ReadLine();

                if(input.ToLower() == "q")
                {
                    doContinue = false;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                }
                Console.WriteLine("Unique numbers: " + string.Join(", ", GetUniqueNumber(numbers.ToArray())));
            } while (doContinue);
        }

        public static int[] GetUniqueNumber(int[] numbers)
        {
            return numbers.Distinct().ToArray();
        }
    }
}
