using System;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override string SaveGoal()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isCompleted}";
    }

    public static new SimpleGoal LoadGoal(string[] parts)
    {
        return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
}
