public class SwimmingLaps : Activity
{
    private double _laps;
    public SwimmingLaps(string date, double timeLength, double laps) : base(date, timeLength)
    {
        _laps = laps;
        _activityName = "Swimming Laps";
    }

    public override double GetKPH()
    {
        double km = _laps * 50 / 1000;
        double hrs = _timeLength / 60;
        double kph = km / hrs;
        return kph;
    }

    public override double GetMeters()
    {
        double meters = _laps * 50;
        return meters;
    }

    public override double GetPace()
    {
        double km = GetMeters() / 1000;
        double pace = _timeLength / km;
        return pace;
    }
}