public class Running : Activity
{
    // distance is in meters
    private double _distance;

    public Running(string date, double timeLength, double distance) : base(date, timeLength)
    {
        _distance = distance;
        _activityName = "Running";
    }

    public override double GetKPH()
    {
        double km = _distance / 1000;
        double hours = _timeLength / 60;
        double kph = km / hours;
        return kph;
    }

    public override double GetMeters()
    {
        return _distance;
    }

    public override double GetPace()
    {
        // pace is minutes per kilometer
        double km = _distance / 1000;
        return _timeLength / km;
    }
}