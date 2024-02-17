public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private int _zipCode;
    public Address(string streetAddress, string city, string stateProvince, int zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = stateProvince;
        _zipCode = zipCode;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state} {_zipCode}";
    }

}