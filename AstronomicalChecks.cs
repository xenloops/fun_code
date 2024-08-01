

using System;

public class AstronomicalChecks
{
    // ChatGPT's solution
    public static bool IsFullMoon(DateTime date)
    {
        // Reference date for a known full moon (January 1, 2023)
        DateTime fullMoonReference = new DateTime(2023, 1, 1);
        
        // Calculate the number of days since the reference full moon
        double daysSinceReference = (date - fullMoonReference).TotalDays;
        
        // Full moon occurs approximately every 29.53 days
        double lunarCycle = 29.53;

        // Calculate the phase of the moon
        double phase = daysSinceReference % lunarCycle;

        // A phase close to 0 means it's a full moon
        return Math.Abs(phase) < 1; // Allow a small tolerance for calculation
    }
}



