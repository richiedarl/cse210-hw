using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() 
        : base("Reflecting", "This activity helps you reflect on times in your life.")
    {
        _prompts = new List<string>();
        _questions = new List<string>();

        // TODO: Add prompts and questions to lists
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
        // TODO: Show a random prompt
    }

    public void DisplayQuestions()
    {
        // TODO: Loop through questions
    }
}