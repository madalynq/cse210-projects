using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to tie shoelaces", "Miles Anderson", 100);
        video1.AddComment(new Comment("Alison", "Great video!"));
        video1.AddComment(new Comment("Brian", "This helped a lot!"));
        video1.AddComment(new Comment("Charlie", "Thank you!"));
        videos.Add(video1);

        Video video2 = new Video("How to cook Spaghetti", "Jenna Morales", 300);
        video2.AddComment(new Comment("Dave", "This helped so much."));
        video2.AddComment(new Comment("Charlie", "Clear and easy to follow."));
        videos.Add(video2);

        Video video3 = new Video("How to Breakdance", "Leo Nakamura", 500);
        video3.AddComment(new Comment("Grady", "Nice video."));
        videos.Add(video3);

        Video video4 = new Video("How to cook Chicken", "Tanya Reeves", 200);
        video4.AddComment(new Comment("Jane", "This video is great!"));
        video4.AddComment(new Comment("Bob", "So good!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}
