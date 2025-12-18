using System;
    class LOT
{
    public static void LargestofThree()
    {
        int a = 5, b = 2, c = 10;
        if(a>b && a > c)
        {
            Console.WriteLine("A is the largest");
        } else if(b > c)
        {
            Console.WriteLine("B is the largest");
        }
        else
        {
            Console.WriteLine("C is the largest");
        }
    }
}