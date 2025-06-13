using System;

public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public override void Complete()
    {
        CurrentCount++;
        Console.WriteLine($"You recorded progress for checklist goal '{_name}'. You earned {_value} points.");

        if (CurrentCount >= TargetCount)
        {
            _completed = true;
            Console.WriteLine($"Congratulations! Goal '{_name}' completed {TargetCount} times. You earned a bonus of {_value} points.");
        }
    }
}