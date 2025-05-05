using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade? ");
        string grade1 = Console.ReadLine();
        int grade = int.Parse(grade1);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";

        int last_digit = grade % 10;

        if (last_digit >= 7)
        {
            sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (grade >= 93)
        {
            sign = "";
        }

        if (grade < 60)
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is a(n) {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class!");
        }
        else
        {
            Console.WriteLine("Please make every effort to improve and try again.");
        }

    }
}