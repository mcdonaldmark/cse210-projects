using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override void Complete()
    {
        Completed = true;
        Console.WriteLine($"Goal '{Name}' completed! You earned {Value} points.");
    }
}