using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {
    }

    public override void Complete()
    {
        Console.WriteLine($"You recorded progress for eternal goal '{_name}'. You earned {_value} points.");
    }
}