using System;
using System.Reflection.Emit;

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
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is {sum}.");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}.");

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The max is: {max}");

        int min = numbers.Where(num => num > 0).Min();

        Console.WriteLine($"The minimum positive value is: {min}");

        numbers.Sort();

        Console.WriteLine("Sorted numbers:");
        for (int i = 0; i < numbers.Count; i++)
        {
            int num = numbers[i];
            Console.WriteLine(num);
        }


    }
}