using System;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Proverbs", 5, 6);
        string originalScriptureText = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, originalScriptureText);

        do
        {
            Console.Clear();
            DisplayScripture(scripture);

            Console.Write("\nPress Enter to continue or type 'quit' to exit: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            HideRandomWords(scripture, 2);

        } while (!scripture.IsCompletelyHidden());

        Console.Clear();
        DisplayScripture(scripture);
        Console.WriteLine("\n");

        Console.WriteLine(originalScriptureText);
        Console.WriteLine("\n");
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.GetDisplayText());
    }

    static void HideRandomWords(Scripture scripture, int numberOfWordsToHide)
    {
        scripture.HideRandomWords(numberOfWordsToHide);
    }
}