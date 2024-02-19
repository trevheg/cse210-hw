public abstract class Activity
{
    private DateTime _date;
    protected double _timeLength;
    protected string _activityName;
    public Activity(string date, double timeLength)
    {
        _date = DateTime.Parse(date);
        _timeLength = timeLength;
    }

    public abstract double GetMeters();
    public abstract double GetKPH();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        double km = Math.Round(GetMeters() / 1000, 2);
        double kph = Math.Round(GetKPH(), 2);
        double mpk = Math.Round(GetPace(), 2);
        return $"{_date.ToShortDateString()} - {_activityName} ({_timeLength} minutes) - Distance: {km} km, Speed: {kph} kph, Pace: {mpk} min per km";
    }
}