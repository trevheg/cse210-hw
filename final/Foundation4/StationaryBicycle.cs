
using System.IO.Pipes;
using System.Reflection;

public class StationaryBicycle : Activity
{
    // speed is kph
    private double _speed;
    public StationaryBicycle(string date, double timeLength, double speed) : base(date, timeLength)
    {
        _speed = speed;
        _activityName = "Stationary Bicycle";
    }
    public override double GetKPH()
    {
        return _speed;
    }
    public override double GetMeters()
    {
        double hrs = _timeLength / 60;
        double km = _speed * hrs;
        double meters = km * 1000;
        return meters;
    }
    public override double GetPace()
    {
        // pace is min / km 
        double km = GetMeters() / 1000;
        double pace = _timeLength / km;
        return pace;
    }
}