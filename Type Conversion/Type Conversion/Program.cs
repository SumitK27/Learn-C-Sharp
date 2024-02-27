namespace Type_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byteNumber = 1;
            string strNumber = "1234";
            int intNumber = 1;
            float floatNumber = 1.0f;
            char charNumber = '1';


            // Implicit Conversion
            int byteToInt = byteNumber;
            Console.WriteLine(byteToInt);

            float intToFloat = intNumber;
            Console.WriteLine(intToFloat);

            char convertedCharNumber = charNumber;
            Console.WriteLine(convertedCharNumber);


            // Explicit Conversion
            byte intToByte = (byte)intNumber;
            Console.WriteLine(intToByte);

            int floatToInt = (int)floatNumber;
            Console.WriteLine(floatToInt);

            int stringToInt = Convert.ToInt32(strNumber);
            int stringToInt2 = int.Parse(strNumber);
            Console.WriteLine(stringToInt);
            Console.WriteLine(stringToInt2);

            string intToString = intNumber.ToString();
            Console.WriteLine(intToString);

            // Non-compatible types
            try
            {
                string nonCompatible = "1234";
                byte nonCompatibleByte = Convert.ToByte(nonCompatible);
                Console.WriteLine(nonCompatibleByte);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string str = "true";
                bool strToBool = Convert.ToBoolean(str);
                Console.WriteLine(strToBool);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
