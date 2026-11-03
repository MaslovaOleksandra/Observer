public class Subscriber : IObserver
{
    public string Name { get; }
    public Subscriber(string name)
    {
        Name = name;
    }
    public void Update(string message)
    {
        Console.WriteLine("{Name}: {message}");
    }
}