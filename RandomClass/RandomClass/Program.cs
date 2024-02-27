namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var randomNumber = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomNumber.Next(1, 10));
            }

            const int PassLen = 10;
            var buffer = new char[PassLen];
            for (int i = 0; i < PassLen; i++)
            {
                buffer[i] = (char)('a' + randomNumber.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
