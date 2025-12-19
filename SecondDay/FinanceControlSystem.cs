using System;

class FCS
{
    public static void FinanceControlSystem()
    {
        string get_out = "";
        // double current_balance = 50000;

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
                    int age;
                    do{
                    Console.Write("Enter your age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    if(age < 0)
                        {
                            Console.WriteLine("Age cannot be negative.");
                        }
                    }while(age<0);
                    int income;
                    do{
                    Console.Write("Enter your monthly income: ");
                    income = Convert.ToInt32(Console.ReadLine());
                        if (income < 0)
                        {
                            
                            Console.WriteLine("Income cannot be less than zero");
                        }
                    }while(income<0);
                    if (age >= 21 && income >= 30000)
                        Console.WriteLine("You are eligible for loan.");
                    else if (age < 21)
                        Console.WriteLine("Age must be at least 21.");
                    else
                        Console.WriteLine("Minimum monthly income should be 30,000.");

                    break;

                case 2:
                    Console.WriteLine("\nIncome Tax Calculator");
                    int annual_income;
                do{
                    Console.Write("Enter your annual income: ");
                    annual_income = Convert.ToInt32(Console.ReadLine());
                      if (annual_income < 0)
        {
            Console.WriteLine("Income cannot be negative. Please enter again.");
        }
                }while(annual_income<0);
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
                    string choose = "";
                    int ch;
                    string leave = "";
                    do{
                        Console.WriteLine("1.Debit: \n2.Credit: \n3.Exit: ");
                    Console.Write("Enter Your Choice: ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            DBT.DebitClass();
                            break;
                        
                        case 2:
                            CDT.CreditClass();
                            break;
                        case 3:
                            leave = "exit";
                            break;

                        default:
                            Console.WriteLine("Enter Valid Choice.");
                            choose = "invalid";
                            break;
                    }
                    }while(choose == "invalid" || leave != "exit");
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
