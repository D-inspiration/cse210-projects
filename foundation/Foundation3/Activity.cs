using System;
using System.Collections.Generic;

public abstract class Activity
{
    private string name;
    private int duration; // in minutes

    public Activity(string name, int duration)
    {
        this.name = name;
        this.duration = duration;
    }

    public string Name { get { return name; } }
    public int Duration { get { return duration; } }

    public virtual double GetDistance() { return 0; }
    public virtual double GetSpeed() { return 0; }
    public virtual double GetPace() { return 0; }

    public virtual string GetSummary()
    {
        return $"{Name}: Distance={GetDistance()} km, Speed={GetSpeed()} kph, Pace={GetPace()} min/km";
    }
}
