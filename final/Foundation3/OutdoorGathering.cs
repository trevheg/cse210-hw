
public class OutdoorGathering : Event
{
    string _weather;
    public OutdoorGathering(string title, string description, string dateTime, Address address, string weather) : base(title, description, dateTime, address)
    {
        _weather = weather;
    }

    public override void ListFullDetails()
    {
        ListStandardDetails();
        System.Console.WriteLine($"The weather will be {_weather}, so dress appropriately.");

    }
}