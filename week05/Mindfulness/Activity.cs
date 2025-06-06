using System;
using System.Threading;

// Base class for activities
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
    }

    public void Start()
    {
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine(_description);

        SetDuration();
        Prepare();

        for (int i = 0; i < _duration; i++)
        {
            PerformAction(i + 1);
            Pause();
        }

        Finish();
    }

    protected void SetDuration()
    {
        Console.Write("Enter duration in seconds: ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    protected void Prepare()
    {
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    protected virtual void Finish()
    {
        Console.WriteLine($"Good job! You have completed the {_name} activity.");
        Console.WriteLine($"Total time: {_duration} seconds");
        Pause(3);
    }

    protected void Pause(int seconds = 1)
    {
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
    }

    protected abstract void PerformAction(int index);
}