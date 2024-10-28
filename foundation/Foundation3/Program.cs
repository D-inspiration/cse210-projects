using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Swimming("Swimming", 60, 20));
        activities.Add(new Running("Running", 60, 5));
        activities.Add(new Cycling("Cycling", 60, 10));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
