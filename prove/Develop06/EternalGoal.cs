using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetStatus()
    {
        return "[]";
    }

    public override string SaveGoal()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }

    public static new EternalGoal LoadGoal(string[] parts)
    {
        return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
}
