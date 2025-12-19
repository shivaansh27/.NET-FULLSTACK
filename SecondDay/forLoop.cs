using System;
class FB
{
    public static void ForLoopBasics()
    {
        for(int i = 20; i <= 30; i++)
        {
            Console.WriteLine($"Table of {i}");
            for(int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i*j}");
            }
        }
    }
}