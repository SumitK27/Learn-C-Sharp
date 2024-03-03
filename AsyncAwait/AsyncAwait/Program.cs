using System.Net;

namespace AsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /*
             * Async:
             * Asynchronous programming is a means of parallel programming in which a unit of work runs separately from the main 
             * application thread and notifies the calling thread of its completion, failure or progress.
             * Used to perform long-running tasks without blocking the main thread.
             * Example: Web requests, file I/O, database operations, etc.
             * Traditionally multi-threading or callbacks were used for asynchronous programming.
             * Modern C# provides async and await keywords to simplify asynchronous programming.
             * Async returns a Task or Task<T> object, which represents an asynchronous operation.
             */
            Console.WriteLine("'av' async without returning");
            Console.WriteLine("'sv' sync without returning");
            Console.WriteLine("'ar' async with returning");
            Console.WriteLine("'sr' sync with returning");
            Console.WriteLine("Enter the operation type: ");
            var operationType = Console.ReadLine();

            if (operationType == "av")
            {
                RunVoidAsync();
            }
            else if (operationType == "sv")
            {
                RunVoidSync();
            }
            else if (operationType == "ar")
            {
                var result = await GetHtmlAsync();
                Console.WriteLine(result);
            }
            else if (operationType == "sr")
            {
                var result = GetHtmlSync();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid operation type");
            }
        }

        private static void RunVoidSync()
        {
            var webClient = new WebClient();
            var result = webClient.DownloadString("https://msdn.microsoft.com");

            using (var writer = new StreamWriter("result.html"))
            {
                writer.Write(result);
                Console.WriteLine("Writing completed!");
            }
        }

        private static async Task RunVoidAsync()
        {
            var webClient = new WebClient();
            var result = await webClient.DownloadStringTaskAsync("https://msdn.microsoft.com");

            using (var writer = new StreamWriter("result.html"))
            {
                await writer.WriteAsync(result);
            }
        }

        private static string GetHtmlSync()
        {
            var webClient = new WebClient();
            return webClient.DownloadString("https://msdn.microsoft.com");
        }

        private static async Task<string> GetHtmlAsync()
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync("https://msdn.microsoft.com");
        }
    }
}
