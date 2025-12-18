using System;
class RN
{
    public static void ReverseNumber()
    {
        Console.Write("Enter the no you want to reverse: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int rev = 0;
        while (a > 0)
        {
            int temp = a%10;
            rev = 10*rev + temp;
            a/=10;
        }
            Console.WriteLine(rev);
    }
}