public class YoutubeChannel
{
    private List<IObserver> observers = new();
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
        Console.WriteLine("Nové video: {title}");
        Notify($"Kanál {ChannelName} vydal nové video: {title}");
    }
}
