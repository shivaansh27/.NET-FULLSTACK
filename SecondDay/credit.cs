using System;

class CDT
{
    public static void CreditClass()
    {   
        string leave = "";
        do{
        Console.WriteLine("1.Net Salary Credit Calculation");
        Console.WriteLine("2.Fix Deposit Maturity Calculation");
        Console.WriteLine("3.Credit Card Reward Point Evaluation");
        Console.WriteLine("4.Employee Bonus Eligiblity Check");
        Console.WriteLine("5.Exit");
        Console.Write("Enter Your Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Enter Gross Salary: ");
                double gross_salary;
                do
                {
                    gross_salary = Convert.ToDouble(Console.ReadLine());
                    if (gross_salary < 0)
                    {
                        Console.WriteLine("Gross Salary Cannot Be Less Than Zero.");
                    }
                } while (gross_salary < 0);
                double fix_deduction = 0.1 * gross_salary;
                Console.WriteLine($"Net Salary Credited: {gross_salary - fix_deduction}");
                break;

            case 2:
                double principle_amount;
                double rate;
                int time;
                do
                {
                    Console.Write("Please Enter Principal Amount: ");
                    principle_amount = Convert.ToDouble(Console.ReadLine());
                    if (principle_amount < 0)
                    {
                        Console.WriteLine("Principle Amount cannot be less than zero");
                    }
                } while (principle_amount < 0);
                do
                {
                    Console.Write("Please Enter Rate Of Interest: ");
                    rate = Convert.ToDouble(Console.ReadLine());
                    if (rate < 0)
                    {
                        Console.WriteLine("Rate Cannot Be Negative");
                    }
                } while (rate < 0);
                do
                {
                    Console.Write("Please Enter Time: ");
                    time = Convert.ToInt32(Console.ReadLine());
                    if (time < 0)
                    {
                        Console.WriteLine("Time cannot be negative");
                    }
                } while (time < 0);
                double simple_interest = (principle_amount * rate * time) / 100;
                Console.WriteLine($"Fixed Deposit maturity amount: ₹{principle_amount + simple_interest}");
                break;

            case 3:
                double spending;
                do
                {
                    Console.Write("Please Enter Your Total Credit Card Spending: ");
                    spending = Convert.ToDouble(Console.ReadLine());
                    if (spending < 0)
                    {
                        Console.WriteLine("Spending cannot be negative");
                    }
                } while (spending < 0);
                double points = spending / 100;
                Console.WriteLine($"Reward points earned: {points}");
                break;

            case 4:
                double annual_salary;
                do
                {
                    Console.Write("Please Enter Your Annual Salary: ");
                    annual_salary = Convert.ToDouble(Console.ReadLine());

                    if (annual_salary < 0)
                        Console.WriteLine("Salary cannot be negative.");

                } while (annual_salary < 0);

                double years_of_service;
                do
                {
                    Console.Write("Please Enter Your Years Of Service: ");
                    years_of_service = Convert.ToDouble(Console.ReadLine());

                    if (years_of_service < 0)
                        Console.WriteLine("Years of service cannot be negative.");

                } while (years_of_service < 0);
                if(annual_salary >= 500000 && years_of_service >= 3)
                {
                    Console.WriteLine("Employee is eligible for bonus");
                }
                else
                {
                    Console.WriteLine("Employee is not eligible for bonus");
                }
                break;
            
            case 5:
                leave = "exit";
                break;
        }
        }while(leave!="exit");
    }
}