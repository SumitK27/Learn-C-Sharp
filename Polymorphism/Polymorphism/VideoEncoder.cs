namespace Polymorphism
{
    public class VideoEncoder
    {
        private readonly MailService mailService;
        private readonly IList<INotificationChannel> notificationChannels;

        public VideoEncoder()
        {
            notificationChannels = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            // Video encoding logic

            foreach (var channel in notificationChannels)
            {
                channel.Send(new Message());
            }
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            notificationChannels.Add(channel);
        }
    }
}
