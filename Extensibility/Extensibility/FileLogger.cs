namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }
        public void LogError(string message)
        {
            Log(message, "Error");
        }

        public void LogInfo(string message)
        {
            Log(message, "Info");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWritter = new StreamWriter(path, true))
            {
                streamWritter.WriteLine($"{messageType}: {message}");
            }
        }
    }
}
