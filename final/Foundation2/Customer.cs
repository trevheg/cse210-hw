public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUsa()
    {
        return _address.InUsa();
    }
    public Address GetAddress()
    {
        return _address;
    }
    public string GetName()
    {
        return _name;
    }
}