// couldn't quite get this to work. 

public class DailyGoal : Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private bool _isComplete;
    private DateTime _lastCompleted;

    public DailyGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
        _lastCompleted = DateTime.Today.AddDays(-1).Date;
    }
    public DailyGoal(string name, string description, int points, bool isComplete, DateTime lastCompleted) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
        _lastCompleted = lastCompleted;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        _lastCompleted = DateTime.Now.Date;
        return _points;
    }
    public bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (_lastCompleted < DateTime.Now.Date)
        {
            _isComplete = false;
        }
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        string oldString = base.GetDetailsString();
        return $"{checkbox} {oldString}";
    }
    public override string GetStringRepresentation()
    {
        
        return $"{this.GetType()}|{_shortName}|{_description}|{_points}|{_isComplete}|{_lastCompleted}";
    }
}