using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Create a videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial for Beginners", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Great video! Very helpful."));
        video1.AddComment(new Comment("Bob", "Thanks for explaining abstraction well."));
        video1.AddComment(new Comment("Charlie", "Clear and concise."));

        Video video2 = new Video("Top 10 Travel Destinations", "Globe Trotter", 450);
        video2.AddComment(new Comment("David", "Adding these to my bucket list!"));
        video2.AddComment(new Comment("Emma", "Beautiful editing."));
        video2.AddComment(new Comment("Frank", "Where was the 3rd location filmed?"));

        Video video3 = new Video("How to Bake a Cake", "Chef Maria", 300);
        video3.AddComment(new Comment("Grace", "Tried this recipe and it was delicious!"));
        video3.AddComment(new Comment("Hannah", "Can I substitute sugar with honey?"));
        video3.AddComment(new Comment("Ian", "Looks so good, thanks for sharing."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display the video and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}