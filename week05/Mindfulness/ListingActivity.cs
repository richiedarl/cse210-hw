using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity() 
        : base("Listing", "This activity helps you list positive things.")
    {
        _prompts = new List<string>();
        _count = 0;

        // TODO: Add prompts
    }

    public void Run()
    {
        StartActivity();

        GetUserList();

        EndActivity();
    }

    public void GetUserList()
    {
        // TODO: Collect user input into a list
    }
}