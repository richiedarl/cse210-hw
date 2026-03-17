using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class PromptGenerator
{
    // used underscores _ to handle the fact that the variable is public and to avoid confusion with local variables.
    // This is used to generate random prompts for the journal entries.
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What made me smile today?",
        "What challenge did I overcome today?",
        "What is one thing I learned today?"
    };

    public string GetRandomPrompt()
    {

        // Next is used to move to the next random number. 
        // The count is used to get the number of prompts in the list. 
        // This ensures that the index is within the bounds of the list.
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}