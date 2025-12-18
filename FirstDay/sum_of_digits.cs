using System;
class SOD
{
    public static void SumOfDigits()
    {
        Console.Write("Enter the digit whose sum you want to find: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (a > 0)
        {
            int temp = a%10;
            sum+=temp;
            a/=10;
        }
        Console.WriteLine($"The sum of digits is: {sum}");
    }
}