using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    private double distance; // in km

    public Cycling(string name, int duration, double distance) : base(name, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance() { return distance; }
    public override double GetSpeed() { return (distance / Duration) * 60; }
    public override double GetPace() { return Duration / distance; }
}
