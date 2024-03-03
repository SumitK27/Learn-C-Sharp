namespace Events
{
    public class VideoEncoder
    {
        // 1. Define a delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // 2. Define an event based on that delegate
        public event VideoEncodedEventHandler? VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            // Check if there are any subscribers
            if (VideoEncoded != null)
                // 3. Raise the event
                // this - the object that is publishing this event
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
