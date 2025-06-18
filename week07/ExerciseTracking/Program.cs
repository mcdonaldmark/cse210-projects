using System;

public class Program
{
    public static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2025, 11, 03), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2025, 11, 03), 30, 6.0);
        Swimming swimming = new Swimming(new DateTime(2025, 11, 03), 30, 10);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}