public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;
    public Event(string title, string description, string dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = DateTime.Parse(dateTime);
        _address = address;
    }
    public void ListStandardDetails()
    {
        System.Console.WriteLine($"Event title: {_title}");
        System.Console.WriteLine($"Description: {_description}");
        System.Console.WriteLine($"Date: {_dateTime.ToShortDateString()}");
        System.Console.WriteLine($"Time: {_dateTime.ToShortTimeString()}");
        System.Console.WriteLine(_address.GetAddress());

    }
    public abstract void ListFullDetails();
}