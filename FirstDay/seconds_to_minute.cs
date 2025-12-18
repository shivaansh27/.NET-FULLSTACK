using System;
class STM
{
    public static void SecondsToMinutes()
    {
        Console.WriteLine("Enter Seconds: ");
        int seconds  = Convert.ToInt32(Console.ReadLine());
        double minutes = seconds/60;
        Console.WriteLine($"Minutes: {minutes}");
    }
}