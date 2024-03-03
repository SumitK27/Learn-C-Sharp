namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Events:
             * - An event is a message sent by an object to signal the occurrence of an action.
             * - Used to communicate between objects.
             * - The object that raises the event is called the publisher and the object that receives the event is called the subscriber.
             * - Used to build loosely coupled applications.
             * - Helps to extend the application.
             */

            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher

            // subscriber
            var mailService = new MailService();
            var messageService = new MessageService();

            // 4. Subscribe to the event
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
