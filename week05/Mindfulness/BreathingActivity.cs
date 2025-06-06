using System;
using System.Threading;

// Breathing Activity
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformAction(int index)
    {
        if (index % 2 == 1)
        {
            Console.WriteLine("Breathe in...");
        }
        else
        {
            Console.WriteLine("Breathe out...");
        }
    }
}