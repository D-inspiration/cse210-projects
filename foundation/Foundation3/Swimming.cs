using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int laps;

    public Swimming(string name, int duration, int laps) : base(name, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() { return laps * 50 / 1000; }
    public override double GetSpeed() { return (GetDistance() / Duration) * 60; }
    public override double GetPace() { return Duration / GetDistance(); }
}
