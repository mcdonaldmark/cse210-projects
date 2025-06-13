using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override void Complete()
    {
        _completed = true;
        Console.WriteLine($"Goal '{_name}' completed! You earned {_value} points.");
    }
}