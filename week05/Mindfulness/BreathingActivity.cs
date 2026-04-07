using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity helps you relax by guiding your breathing.")
    {
    }

    public void Run()
    {
        StartActivity();

        // TODO: Add breathing logic (inhale/exhale)

        EndActivity();
    }
}