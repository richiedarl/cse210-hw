using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() 
        : base("Reflecting", "This activity helps you reflect on times in your life.")
    {
        _prompts = new List<string>()
        {
            "Think of a time you overcame a challenge.",
            "Think of a time you helped someone.",
            "Think of a time you felt proud."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful?",
            "What did you learn from it?",
            "How did you feel at the time?",
            "What would you do differently?"
        };
    }

    public void Run()
    {
        StartActivity();

        DisplayPrompt();
        DisplayQuestions();

        EndActivity();
    }

    public void DisplayPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt:\n{prompt}");
        Console.WriteLine("Think about it...");
        ShowSpinner(5);
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("\nNow consider the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_questions[i % _questions.Count]);
            ShowSpinner(4);
            i++;
        }
    }
}