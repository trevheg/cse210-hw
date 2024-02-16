public class Address 
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _regionCode; 
    private string _country;
    public Address(string streetAddress, string city, string stateProvince, string regionCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _regionCode = regionCode;
        _country = country;
    }

    public bool InUsa()
    {
        return _country == "USA";
    }
    public string GetAddress()
    {
        if (_country == "USA")
        {
            return $"{_streetAddress}\n{_city}, {_stateProvince} {_regionCode}";
        }
        else 
        {            
            return $"{_streetAddress}\n{_city}, {_stateProvince} {_regionCode}\n{_country}";
        }
    }

}