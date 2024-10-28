using System;

class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    // Method to record the event
    public virtual int RecordEvent()
    {
        _isCompleted = true;
        return _points;
    }

    // Method for status of goal
    public virtual string GetStatus()
    {
        return _isCompleted ? "[x]" : "[]";
    }

    public virtual void Display()
    {
        Console.WriteLine($"{GetStatus()} {_shortName} ({_points} points)");
    }

    // Save format for base Goal
    public virtual string SaveGoal()
    {
        return $"Goal|{_shortName}|{_description}|{_points}|{_isCompleted}";
    }

    // Load Goal from file
    public static Goal LoadGoal(string[] parts)
    {
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        bool isCompleted = bool.Parse(parts[4]);
        return new Goal(name, description, points) { _isCompleted = isCompleted };
    }
}
