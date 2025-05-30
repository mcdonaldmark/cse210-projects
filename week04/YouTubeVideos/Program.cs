using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Star Wars The Old Republic", "Obi Wan", 3040);
        video1._comments.Add(new Comment("Miriam", "Great video!"));
        video1._comments.Add(new Comment("Veronica", "Thanks for the tutorial!"));
        video1._comments.Add(new Comment("Hector", "Very helpful, thanks!"));
        video1._comments.Add(new Comment("Giovanni", "Wonderful"));
        videos.Add(video1);

        Video video2 = new Video("Star Wars The Force Awakens", "Yoda", 2300);
        video2._comments.Add(new Comment("Miriam", "Great video!"));
        video2._comments.Add(new Comment("Veronica", "Thanks for the tutorial!"));
        video2._comments.Add(new Comment("Hector", "Very helpful, thanks!"));
        video2._comments.Add(new Comment("Giovanni", "Wonderful"));
        videos.Add(video2);

        Video video3 = new Video("Debugging Tips in C#", "Mike Johnson", 2000);
        video3._comments.Add(new Comment("Miriam", "Great video!"));
        video3._comments.Add(new Comment("Veronica", "Thanks for the tutorial!"));
        video3._comments.Add(new Comment("Hector", "Very helpful, thanks!"));
        video3._comments.Add(new Comment("Giovanni", "Wonderful"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of comments: " + video.numComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine("- " + comment._name + ": " + comment._text);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}