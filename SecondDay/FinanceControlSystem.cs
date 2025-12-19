using System;

class FCS
{
    public static void FinanceControlSystem()
    {
        string get_out = "";
        double current_balance = 50000;

        do
        {
            Console.WriteLine("\nWelcome to Finance Control System");
            Console.WriteLine("1. Loan Eligibility Check");
            Console.WriteLine("2. Income Tax Calculation");
            Console.WriteLine("3. Transaction Entry System");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Your Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nLoan Eligibility Check");
                    Console.Write("Enter your age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter your monthly income: ");
                    int income = Convert.ToInt32(Console.ReadLine());

                    if (age >= 21 && income >= 30000)
                        Console.WriteLine("You are eligible for loan.");
                    else if (age < 21)
                        Console.WriteLine("Age must be at least 21.");
                    else
                        Console.WriteLine("Minimum monthly income should be 30,000.");

                    break;

                case 2:
                    Console.WriteLine("\nIncome Tax Calculator");
                    Console.Write("Enter your annual income: ");
                    int annual_income = Convert.ToInt32(Console.ReadLine());

                    if (annual_income <= 250000)
                        Console.WriteLine("No tax applicable.");
                    else if (annual_income <= 500000)
                        Console.WriteLine($"Income Tax: {0.05 * annual_income}");
                    else if (annual_income <= 1000000)
                        Console.WriteLine($"Income Tax: {0.2 * annual_income}");
                    else
                        Console.WriteLine($"Income Tax: {0.3 * annual_income}");

                    break;

                case 3:
                    Console.WriteLine($"\nCurrent Balance: {current_balance}");
                    Console.Write("Enter withdrawal amount: ");
                    double withdrawal_amount = Convert.ToDouble(Console.ReadLine());

                    if (withdrawal_amount <= 0)
                        Console.WriteLine("Amount must be greater than zero.");
                    else if (withdrawal_amount > current_balance)
                        Console.WriteLine("Insufficient balance.");
                    else
                    {
                        current_balance -= withdrawal_amount;
                        Console.WriteLine("Withdrawal successful.");
                        Console.WriteLine($"Remaining Balance: {current_balance}");
                    }

                    break;

                case 4:
                    Console.WriteLine("Exiting system...");
                    get_out = "exit";
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (get_out != "exit");
    }
}
