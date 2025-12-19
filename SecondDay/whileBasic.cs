using System;
using System.Runtime.InteropServices;
class WB
{
    public static void WhileBasics()
    {
        int count = 1;
        // while (count < 6)
        // {
        //     Console.WriteLine(count);
        //     count++;
        // }
        do
        {
            Console.WriteLine(count);
            count++;
        }while(count<6);
    }
}