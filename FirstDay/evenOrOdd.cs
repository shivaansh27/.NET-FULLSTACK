using System;
class EO
{
    public static void EvenOrOdd()
    {
        Console.WriteLine("Write the Number: ");
        int no = Convert.ToInt32(Console.ReadLine());
        if (no % 2 == 0)
        {
            Console.WriteLine("This no is even");
        }
        else
        {
            Console.WriteLine("This no is not even or is odd");
        }
    }
}