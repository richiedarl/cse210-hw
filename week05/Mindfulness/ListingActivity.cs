using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity() 
        : base("Listing", "This activity helps you list positive things.")
    {
        _prompts = new List<string>()
        {
            "Who are people you appreciate?",
            "What are your personal strengths?",
            "What made you smile today?",
            "Who have you helped recently?"
        };

        _count = 0;
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("Start listing items. Press Enter after each one.");

        GetUserList();

        Console.WriteLine($"You listed {_count} items!");

        EndActivity();
    }

    public void GetUserList()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }
    }
}