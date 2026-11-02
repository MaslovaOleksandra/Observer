namespace YoutubeChanne
{
    public class YoutubeChannel
    {
        private List&lt;IObserver&gt; observers = new();
        public string ChannelName { get; }
        public YoutubeChannel(string channelName)
        {
            ChannelName = channelName;
        }
        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }
        private void Notify(string message)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(message);
            }
        }
        public void UploadVideo(string title)
        {
            Console.WriteLine($&quot;Nové video: {title}&quot;);
            Notify($&quot;Kanál {ChannelName} vydal nové video: {title}&quot;);
        }
    }
}
