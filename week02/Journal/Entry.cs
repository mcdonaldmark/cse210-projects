using System;

public class Entry
{
    public DateTime DateCreated { get; set; }
    public string Content { get; set; }
    public string Prompt { get; set; }
    public string Name { get; set; }

    //Initializes the date and content of an entry from user input
    public Entry(string name, string prompt, string content)
    {
        DateCreated = DateTime.Now;
        Prompt = prompt;
        Name = name;
        Content = content;
    }

    //Displays the content of an entry
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {DateCreated}\nPrompt: {Prompt}\nBy: {Name}\nContent: {Content}\n");
    }

}