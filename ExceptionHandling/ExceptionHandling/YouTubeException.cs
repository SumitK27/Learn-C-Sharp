namespace ExceptionHandling
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception exception) : base(message, exception)
        {
            
        }
    }
}
