using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        string response = "";

        int guess = 0;
        int attempts = 0;

        while (guess != magic)

        {

            do
            {

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                attempts++;

                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} tries!");

                    Console.Write("Do you want to continue? ");
                    response = Console.ReadLine();

                    if (response == "no")
                    {
                        Console.WriteLine("Have a great day!");
                    }
                    else if (response == "yes")
                    {
                        attempts = 0;
                        guess = 0;
                        magic = randomGenerator.Next(1, 101);
                    }
                }
            } while (response == "yes");
        }
    }
}