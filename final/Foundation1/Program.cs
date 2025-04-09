using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Understanding Abstraction", "TechGuru", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "This really helped me understand abstraction."));
        video1.AddComment(new Comment("Charlie", "Awesome video, thanks!"));
        videos.Add(video1);
        Video video2 = new Video("C# Interfaces Explained", "CodeMaster", 720);
        video2.AddComment(new Comment("David", "Very informative."));
        video2.AddComment(new Comment("Emma", "Loved the real-world examples."));
        video2.AddComment(new Comment("Frank", "Simple and clear!"));
        videos.Add(video2);
        Video video3 = new Video("Design Patterns in C#", "DevSensei", 900);
        video3.AddComment(new Comment("Grace", "Finally, I understand Singleton!"));
        video3.AddComment(new Comment("Hank", "Really useful for my project."));
        video3.AddComment(new Comment("Ivy", "Thanks for this detailed explanation."));
        videos.Add(video3);
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}