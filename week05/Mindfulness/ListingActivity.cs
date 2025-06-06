using System;
using System.Threading;

// Listing Activity
public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int itemCount;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformAction(int index)
    {
        if (index == 1)
        {
            Console.WriteLine(_prompts[new Random().Next(_prompts.Length)]);
        }
        else
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            itemCount++;
        }
    }

    protected override void Finish()
    {
        base.Finish();
        Console.WriteLine($"Total items listed: {itemCount}");
    }
}