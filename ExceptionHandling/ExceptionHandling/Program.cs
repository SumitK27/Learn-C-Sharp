namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- TryCatchExample -----------");
            ExceptionHandlingExamples.TryCatchExample();

            Console.WriteLine("----------- TryCatchFinallyExample -----------");
            ExceptionHandlingExamples.TryCatchFinallyExample();

            Console.WriteLine("----------- TryCatchFinallyExampleWithUsing -----------");
            ExceptionHandlingExamples.TryCatchFinallyExampleWithUsing();

            Console.WriteLine("----------- Custom Exception -----------");
            ExceptionHandlingExamples.CustomExceptionExample();
        }
    }
}
