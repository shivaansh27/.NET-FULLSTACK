using System;

class DBT
{
    public static void DebitClass()
    {
        string leave = "";
        do{
        Console.WriteLine("\nPlease enter your choice:");
        Console.WriteLine("1. ATM Withdrawal Limit Validation");
        Console.WriteLine("2. EMI Burden Evaluation");
        Console.WriteLine("3. Transaction Based Daily Spending Calculator");
        Console.WriteLine("4. Minimum Balance Compliance Check");
        Console.WriteLine("5. Exit");
        Console.Write("Enter Your Choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                double withdrawal_amount;
                do
                {
                    Console.Write("Enter withdrawal amount: ");
                    withdrawal_amount = Convert.ToDouble(Console.ReadLine());

                    if (withdrawal_amount < 0)
                        Console.WriteLine("Amount cannot be negative.");
                } while (withdrawal_amount < 0);

                if (withdrawal_amount <= 40000)
                    Console.WriteLine("Withdrawal permitted within daily limit.");
                else
                    Console.WriteLine("Daily ATM withdrawal limit exceeded.");
                break;

            case 2:
                double monthly_income;
                do
                {
                    Console.Write("Enter monthly income: ");
                    monthly_income = Convert.ToDouble(Console.ReadLine());

                    if (monthly_income <= 0)
                        Console.WriteLine("Income must be greater than zero.");
                } while (monthly_income <= 0);

                double emi_amount;
                do
                {
                    Console.Write("Enter EMI amount: ");
                    emi_amount = Convert.ToDouble(Console.ReadLine());

                    if (emi_amount < 0)
                        Console.WriteLine("EMI cannot be negative.");
                } while (emi_amount < 0);

                double maxEmi = 0.4 * monthly_income;

                if (emi_amount <= maxEmi)
                    Console.WriteLine("EMI is financially manageable.");
                else
                    Console.WriteLine("EMI exceeds safe income limit.");
                break;

            case 3:
                int transactions;
                do
                {
                    Console.Write("Enter number of transactions: ");
                    transactions = Convert.ToInt32(Console.ReadLine());

                    if (transactions <= 0)
                        Console.WriteLine("Transactions must be greater than zero.");
                } while (transactions <= 0);

                double sum = 0;

                while (transactions > 0)
                {
                    double amount;
                    do
                    {
                        Console.Write("Enter transaction amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());

                        if (amount < 0)
                            Console.WriteLine("Amount cannot be negative.");
                    } while (amount < 0);

                    sum += amount;
                    transactions--;
                }

                Console.WriteLine($"Total debit amount for the day: ₹{sum}");
                break;

            case 4:
                double curr_balance;
                do
                {
                    Console.Write("Enter current balance: ");
                    curr_balance = Convert.ToDouble(Console.ReadLine());

                    if (curr_balance < 0)
                        Console.WriteLine("Balance cannot be negative.");
                } while (curr_balance < 0);

                if (curr_balance >= 2000)
                    Console.WriteLine("Minimum balance requirement satisfied.");
                else
                    Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;

            case 5:
                leave = "exit";
                break;
        }
        }while(leave!="exit");
    }
}
