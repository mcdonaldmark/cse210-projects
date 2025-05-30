using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Introduction to C#", "John Smith", 300);
        v1._comments.Add(new Comment("Alice", "Great video!"));
        v1._comments.Add(new Comment("Bob", "Thanks for the tutorial!"));
        v1._comments.Add(new Comment("Charlie", "Very helpful, thanks!"));
        videos.Add(v1);

        Video v2 = new Video("C# OOP Concepts", "Jane Doe", 450);
        v2._comments.Add(new Comment("David", "Nice explanation of OOP!"));
        v2._comments.Add(new Comment("Eva", "Very informative, thanks!"));
        videos.Add(v2);

        Video v3 = new Video("Debugging Tips in C#", "Mike Johnson", 200);
        v3._comments.Add(new Comment("Frank", "This saved me a lot of time!"));
        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine("Title: " + v._title);
            Console.WriteLine("Author: " + v._author);
            Console.WriteLine("Length: " + v._length + " seconds");
            Console.WriteLine("Number of comments: " + v.numComments());
            Console.WriteLine("Comments:");

            foreach (Comment c in v._comments)
            {
                Console.WriteLine("- " + c._name + ": " + c._text);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}