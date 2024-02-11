public abstract class Goal 
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();


    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description}), {_points} points";
    }
    public abstract string GetStringRepresentation();
}