public abstract class Goal 
{
    private string _shortName;
    private string _description;
    private int _points;
    private bool _complete;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _complete = false;
    }

    public virtual int RecordEvent()
    {
        _complete = true;
        return _points;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool IsComplete()
    {
        return _complete;
    }
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description}), {_points} points";
    }
    public abstract string GetStringRepresentation();
}