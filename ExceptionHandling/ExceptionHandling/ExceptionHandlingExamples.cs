namespace ExceptionHandling
{
    internal static class ExceptionHandlingExamples
    {
        public static void CustomExceptionExample()
        {
            try
            {
                var api = new YouTubeApi();
                api.GetVideos("niko.bellic@email.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException?.Message);
            }
        }

        public static void TryCatchExample()
        {
            try
            {
                Console.WriteLine($"Divide 10 by 0: {Calculator.Divide(10, 0)}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException caught!", e.Message);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("ArithmeticException caught!", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught!", e.Message);
            }
        }

        public static void TryCatchFinallyExample()
        {
            StreamReader? streamReader = null;
            try
            {
                streamReader = new StreamReader("file.txt");
                var content = streamReader.ReadToEnd();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFoundException caught!");
            }
            catch (Exception)
            {
                Console.WriteLine("Generic Exception caught!");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }

        public static void TryCatchFinallyExampleWithUsing()
        {
            try
            {
                // The using statement ensures that Dispose is called even if an exception occurs while you are calling methods on the object.
                using (var streamReader = new StreamReader("file.txt"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFoundException caught!");
            }
            catch (Exception)
            {
                Console.WriteLine("Generic Exception caught!");
            }
        }
    }
}