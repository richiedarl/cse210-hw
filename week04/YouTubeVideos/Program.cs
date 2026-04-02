using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // ---------------- VIDEO 1 ----------------
        Video v1 = new Video("How to Learn C# Fast", "Darlington Okorie", 600);
        v1.AddComment(new Comment("John", "This helped me a lot!"));
        v1.AddComment(new Comment("Sarah", "Clear explanation."));
        v1.AddComment(new Comment("Mike", "Nice video."));
        videos.Add(v1);

        // ---------------- VIDEO 2 ----------------
        Video v2 = new Video("How I Pray Everyday", "CodeMaster", 850);
        v2.AddComment(new Comment("Alex", "This message inspired me."));
        v2.AddComment(new Comment("Jane", "Very uplifting."));
        v2.AddComment(new Comment("Chris", "I needed this today."));
        videos.Add(v2);

        // ---------------- VIDEO 3 ----------------
        Video v3 = new Video("The blessings of new days", "DevWorld", 1200);
        v3.AddComment(new Comment("Tom", "Lovely message on blessings."));
        v3.AddComment(new Comment("Lucy", "Learned a lot."));
        v3.AddComment(new Comment("Mark", "Well explained."));
        videos.Add(v3);

        // ---------------- VIDEO 4 ----------------
        Video v4 = new Video("Cybersecurity Basics", "SecureTech", 700);
        v4.AddComment(new Comment("David", "Important info."));
        v4.AddComment(new Comment("Ella", "Very insightful."));
        v4.AddComment(new Comment("Sam", "Good introduction."));
        videos.Add(v4);

        // ---------------- DISPLAY ----------------
        foreach (Video video in videos)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine("===================================\n");
        }
    }
}