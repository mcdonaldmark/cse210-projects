using System;
using System.Threading;


public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            Activity activity;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Have a great day!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
            }
            Console.Clear();
            activity.Start();
            Console.Clear();
        }
    }
}