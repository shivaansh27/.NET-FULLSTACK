using System;
class FTC
{
    public static void FeetToCentimeter()
    {
        double foot = 30.48;
        Console.Write("Feet to Convert: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        double answer = feet*foot;
        Console.WriteLine($"Answer: {answer}");
    }
}