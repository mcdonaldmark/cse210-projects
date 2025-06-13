using System;

public abstract class Goal
{
    public string _name { get; set; }
    public int _value { get; set; }
    public bool _completed { get; set; }

    public Goal(string name, int value)
    {
        _name = name;
        _value = value;
        _completed = false;
    }

    public abstract void Complete();
}