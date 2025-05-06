using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int number = -1;
        while (number != 0)

        {

            Console.Write("Enter number: ");
            string number1 = Console.ReadLine();
            number = int.Parse(number1);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
    }
}