//exception handling

// using System;

// class Program
// {
//     static void Main()
//     {
//         int a = 10;
//         int b = 0;

//         try
//         {
//             int result = a / b;   
//             Console.WriteLine("Result: " + result);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error occurred: " + ex.Message);
//         }

//         Console.WriteLine("Program executed successfully.");
//     }
// }


// using System;
// using System.IO;

// class InsufficientBalanceException : Exception
// {
//     public InsufficientBalanceException(string message) : base(message) { }
// }

// class BankAccount
// {
//     public decimal Balance { get; private set; } = 5000;

//     public void Withdraw(decimal amount)
//     {
//         if (amount <= 0)
//             throw new ArgumentException("Amount must be greater than zero.");

//         if (amount > Balance)
//             throw new InsufficientBalanceException("Insufficient balance.");

//         Balance -= amount;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             // 1 FormatException
//             Console.WriteLine("Enter withdrawal amount:");
//             decimal amount = decimal.Parse(Console.ReadLine());

//             // 2 DivideByZeroException (intentional)
//             int serviceCharge = 100;
//             int divisionCheck = serviceCharge / int.Parse("0");

//             // 3 FileNotFoundException
//             string data = File.ReadAllText("account.txt");

//             // 4 Business Logic
//             BankAccount account = new BankAccount();
//             account.Withdraw(amount);

//             Console.WriteLine("Withdrawal successful");
//         }
//         catch (FormatException ex)
//         {
//             LogException(ex);
//             Console.WriteLine("Invalid input format.");
//         }
//         catch (DivideByZeroException ex)
//         {
//             LogException(ex);
//             Console.WriteLine("Arithmetic error occurred.");
//         }
//         catch (FileNotFoundException ex)
//         {
//             LogException(ex);
//             Console.WriteLine("Required file not found.");
//         }
//         catch (InsufficientBalanceException ex)
//         {
//             LogException(ex);
//             Console.WriteLine("Business rule violation.");
//         }
//         catch (Exception ex)
//         {
//             LogException(ex);
//             Console.WriteLine("Unexpected error occurred.");
//         }
//         finally
//         {
//             Console.WriteLine("Transaction process completed.");
//         }
//     }

//     static void LogException(Exception ex)
//     {
//         Console.WriteLine("LOG: " + ex.Message);
//     }
// }



//StreamBuzz

using System;
using System.Collections.Generic;

public class CreatorStats
{
    public string CreatorName{get; set;}
    public double[] WeeklyLikes{get; set;}
}

public class Program
{
    public static List<CreatorStats> EngagementBoard=new List<CreatorStats>();

    //RegisterCreator
    public void RegisterCreator(CreatorStats record)
    {
        EngagementBoard.Add(record);
    }

    //GetTop Post Count
    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int>result=new Dictionary<string, int>();
        foreach(CreatorStats creator in records)
        {
            int count=0;
            foreach (double likes in creator.WeeklyLikes)
            {
                if (likes >= likeThreshold)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                result.Add(creator.CreatorName, count);
            }
        }
        return result;
    }
    //Calculate AverageLikes
    public double CalculateAverageLikes()
    {
        double totalLikes=0;
        double totalWeeks=0;

        foreach (CreatorStats creator in EngagementBoard){
            foreach (double likes in creator.WeeklyLikes){
                totalLikes+=likes;
                totalWeeks++;
            }
        }
        if (totalWeeks==0)
        return 0;

        return totalLikes/totalWeeks;
    }

    //Main
    public static void Main()
    {
    Program program = new Program();

    while (true)
    {
        Console.WriteLine("1: Register Creator");
        Console.WriteLine("2: Show Top Posts");
        Console.WriteLine("3: Calculate Average Likes");
        Console.WriteLine("4: Exit");
        Console.WriteLine("Enter Your Choices: ");

        int choice=int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            Console.WriteLine("Enter creator name: ");
            string name=Console.ReadLine();

            double[] likes=new double[4];
            Console.WriteLine("Enter Weekly Likes(1 to 4): ");

            for(int i = 0; i < 4; i++)
                {
                    likes[i]=double.Parse(Console.ReadLine());
                }
                CreatorStats creator=new CreatorStats
                {
                    CreatorName=name,
                    WeeklyLikes=likes,
                };
                program.RegisterCreator(creator);
                Console.WriteLine("Creator Registered Successfully");
                Console.WriteLine();
                break;

            case 2:
            Console.WriteLine("Enter Like Threshold: ");
            double threshold=double.Parse(Console.ReadLine());

            Dictionary<string, int> topPosts=program.GetTopPostCounts(EngagementBoard, threshold);
                if (topPosts.Count == 0)
                {
                    Console.WriteLine("No top-performin posts this week");
                }
                else
                {
                    foreach (var item in topPosts)
                    {
                        Console.WriteLine(item.Key+" - "+item.Value);
                    }
                }
                Console.WriteLine();
                break;

            case 3:
            double average=program.CalculateAverageLikes();
            Console.WriteLine("Overall weekly likes: "+average);
            Console.WriteLine();
            break;

            case 4:
            Console.WriteLine("Logging off-Keep Creating with StreamBuzz!");
            return;

            default:
            Console.WriteLine("Invalid choice");
            Console.WriteLine();
            break;


        }

    }
}
}