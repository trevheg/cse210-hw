public class EternalGoal : Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override int RecordEvent()
    {
        return _points;

    }

    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        string oldString = base.GetDetailsString();
        return $"{checkbox} {oldString}";
    }
    public override string GetStringRepresentation()
    {
        
        return $"{this.GetType()}|{_shortName}|{_description}|{_points}";
    }
}