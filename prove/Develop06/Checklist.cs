using System;

class CheckList : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public CheckList(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (_isCompleted) return 0;

        _currentCount++;
        int pointsEarned = _points;

        if (_currentCount >= _targetCount)
        {
            pointsEarned += _bonus;
            _isCompleted = true;
        }
        return pointsEarned;
    }

    public override string GetStatus()
    {
        return _isCompleted ? "[x]" : $"[{_currentCount}/{_targetCount}]";
    }

    public override void Display()
    {
        Console.WriteLine($"{GetStatus()} {_shortName} ({_points} points each, bonus: {_bonus} points)");
    }

    public override string SaveGoal()
    {
        return $"CheckList|{_shortName}|{_description}|{_points}|{_targetCount}|{_currentCount}|{_bonus}|{_isCompleted}";
    }

    public static new CheckList LoadGoal(string[] parts)
    {
        var goal = new CheckList(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]))
        {
            _currentCount = int.Parse(parts[5]),
            _isCompleted = bool.Parse(parts[7])
        };
        return goal;
    }
}