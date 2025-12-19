using System;
class CS
{
    public static void ContinueStatement()
    {
        Console.WriteLine("Game Begins");
        for(int i = 1;i <= 10; i++)
        {   
             if(i==4){
                Console.WriteLine($"Enemy {i} is invisible. Skipping enemy {i}");
                continue;
             }
            Console.WriteLine($"Player killed enemy {i}");
        }
        Console.WriteLine("Game Ends.");
    }
}