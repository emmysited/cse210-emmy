using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        // Create first video and comments
        Video video1 = new Video("Intro to C#", "McOsutre Emmanuel", 300);
        video1.AddComment(new Comment("Alice", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Bob", "I love how you explained it."));
        video1.AddComment(new Comment("Clara", "Looking forward to more."));

        // Create second video and comments
        Video video2 = new Video("OOP Concepts Explained", "Jane Code", 450);
        video2.AddComment(new Comment("Daniel", "Great content!"));
        video2.AddComment(new Comment("Eva", "This really cleared things up."));
        video2.AddComment(new Comment("Frank", "Excellent explanation."));

        // Create third video and comments
        Video video3 = new Video("Debugging in Visual Studio", "TechWithTim", 360);
        video3.AddComment(new Comment("George", "Exactly what I needed."));
        video3.AddComment(new Comment("Hannah", "You saved my project!"));
        video3.AddComment(new Comment("Isaac", "I finally understand breakpoints."));

        // Add videos to the list
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        // Display all video information and comments
        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(); // Extra spacing between videos
        }
    }
}