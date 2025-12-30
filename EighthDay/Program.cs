//MediSure Clinic: Simple Patient Billing 

// using System;

// class PatientBill
// {
//     public string? BillId { get; set; }
//     public string? PatientName { get; set; }
//     public bool HasInsurance { get; set; }

//     public decimal ConsultationFee { get; set; }
//     public decimal LabCharges { get; set; }
//     public decimal MedicineCharges { get; set; }

//     public decimal GrossAmount { get; set; }
//     public decimal DiscountAmount { get; set; }
//     public decimal FinalPayable { get; set; }
// }

// class BillingService
// {
//     public static PatientBill? LastBill;
//     public static bool HasLastBill = false;
//     public static void CreateNewBill()
//     {
//         PatientBill bill = new PatientBill();

//         // Bill ID validation
//         while (true)
//         {
//             Console.Write("Enter Bill Id: ");
//             bill.BillId = Console.ReadLine();

//             if (!string.IsNullOrWhiteSpace(bill.BillId))
//                 break;

//             Console.WriteLine("Bill Id cannot be empty.");
//         }

//         // Patient Name validation (NO NUMBERS ALLOWED)
//         while (true)
//         {
//             Console.Write("Enter Patient Name: ");
//             string nameInput = Console.ReadLine();

//             bool isValid = true;

//             if (string.IsNullOrWhiteSpace(nameInput))
//             {
//                 isValid = false;
//             }
//             else
//             {
//                 foreach (char c in nameInput)
//                 {
//                     if (!char.IsLetter(c) && c != ' ')
//                     {
//                         isValid = false;
//                         break;
//                     }
//                 }
//             }

//             if (isValid)
//             {
//                 bill.PatientName = nameInput;
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid name. Only alphabets and spaces are allowed.");
//             }
//         }

//         // Insurance input
//         while (true)
//         {
//             Console.Write("Is the patient insured? (Y/N): ");
//             string input = Console.ReadLine()!.ToUpper();

//             if (input == "Y")
//             {
//                 bill.HasInsurance = true;
//                 break;
//             }
//             else if (input == "N")
//             {
//                 bill.HasInsurance = false;
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Please enter Y or N only.");
//             }
//         }

//         // Fees
//         bill.ConsultationFee = ReadDecimal("Enter Consultation Fee: ", true);
//         bill.LabCharges = ReadDecimal("Enter Lab Charges: ", false);
//         bill.MedicineCharges = ReadDecimal("Enter Medicine Charges: ", false);

//         // Calculations
//         bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

//         if (bill.HasInsurance)
//             bill.DiscountAmount = bill.GrossAmount * 0.10m;
//         else
//             bill.DiscountAmount = 0;

//         bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

//         // Store last bill
//         LastBill = bill;
//         HasLastBill = true;

//         // Output
//         Console.WriteLine("\nBill created successfully.");
//         Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
//         Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
//         Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
//         Console.WriteLine("----------------------------");
//     }

//     //  VIEW LAST BILL 
//     public static void ViewLastBill()
//     {
//         if (!HasLastBill || LastBill == null)
//         {
//             Console.WriteLine("No bill available. Please create a new bill first.");
//             return;
//         }

//         Console.WriteLine(" Last Bill");
//         Console.WriteLine($"BillId: {LastBill.BillId}");
//         Console.WriteLine($"Patient: {LastBill.PatientName}");
//         Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
//         Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
//         Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
//         Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
//         Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
//         Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
//         Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
//         Console.WriteLine("--------------------------------");
//         Console.WriteLine("----------------------------------");
//     }

//     //  CLEAR BILL 
//     public static void ClearLastBill()
//     {
//         LastBill = null;
//         HasLastBill = false;
//         Console.WriteLine("Last bill cleared.");
//     }

//     // DECIMAL INPUT HELPER 
//     private static decimal ReadDecimal(string message, bool mustBePositive)
//     {
//         decimal value;

//         while (true)
//         {
//             Console.Write(message);
//             bool valid = decimal.TryParse(Console.ReadLine(), out value);

//             if (!valid)
//             {
//                 Console.WriteLine("Invalid number. Try again.");
//                 continue;
//             }

//             if (mustBePositive && value <= 0)
//             {
//                 Console.WriteLine("Value must be greater than 0.");
//                 continue;
//             }

//             if (!mustBePositive && value < 0)
//             {
//                 Console.WriteLine("Value cannot be negative.");
//                 continue;
//             }

//             return value;
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         bool running = true;

//         while (running)
//         {
//             Console.WriteLine("MediSure Clinic Billing");
//             Console.WriteLine("1. Create New Bill (Enter Patient Details)");
//             Console.WriteLine("2. View Last Bill");
//             Console.WriteLine("3. Clear Last Bill");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your option: ");

//             string choice = Console.ReadLine()!;

//             switch (choice)
//             {
//                 case "1":
//                     BillingService.CreateNewBill();
//                     break;

//                 case "2":
//                     BillingService.ViewLastBill();
//                     break;

//                 case "3":
//                     BillingService.ClearLastBill();
//                     break;

//                 case "4":
//                     Console.WriteLine("\nThank you. Application closed normally.");
//                     running = false;
//                     break;

//                 default:
//                     Console.WriteLine("Invalid option. Please choose between 1 and 4.");
//                     break;
//             }
//         }
//     }
// }




//QuickMart Traders: Profit Calculator 

// using System;

// class SaleTransaction
// {
//     public string? InvoiceNo { get; set; }
//     public string? CustomerName { get; set; }
//     public string? ItemName { get; set; }
//     public int Quantity { get; set; }

//     public decimal PurchaseAmount { get; set; }
//     public decimal SellingAmount { get; set; }

//     public string? ProfitOrLossStatus { get; set; }
//     public decimal ProfitOrLossAmount { get; set; }
//     public decimal ProfitMarginPercent { get; set; }
// }

// class TransactionService
// {
//     public static SaleTransaction? LastTransaction;
//     public static bool HasLastTransaction = false;
//     public static void CreateNewTransaction()
//     {
//         SaleTransaction tx = new SaleTransaction();
//         while (true)
//         {
//             Console.Write("Enter Invoice No: ");
//             tx.InvoiceNo = Console.ReadLine();

//             if (!string.IsNullOrWhiteSpace(tx.InvoiceNo))
//                 break;

//             Console.WriteLine("Invoice No cannot be empty.");
//         }
//         tx.CustomerName = ReadName("Enter Customer Name: ");
//         tx.ItemName = ReadName("Enter Item Name: ");
//         while (true)
//         {
//             Console.Write("Enter Quantity: ");
//             bool ok = int.TryParse(Console.ReadLine(), out int q);

//             if (ok && q > 0)
//             {
//                 tx.Quantity = q;
//                 break;
//             }

//             Console.WriteLine("Quantity must be greater than 0.");
//         }
//         tx.PurchaseAmount = ReadDecimal("Enter Purchase Amount (total): ", true);
//         tx.SellingAmount = ReadDecimal("Enter Selling Amount (total): ", false);

//         CalculateProfitLoss(tx);

//         LastTransaction = tx;
//         HasLastTransaction = true;

//         Console.WriteLine("\nTransaction saved successfully.");
//         Console.WriteLine($"Status: {tx.ProfitOrLossStatus}");
//         Console.WriteLine($"Profit/Loss Amount: {tx.ProfitOrLossAmount:F2}");
//         Console.WriteLine($"Profit Margin (%): {tx.ProfitMarginPercent:F2}");
//         Console.WriteLine("------------------------------------------------------");
//     }
//     public static void ViewLastTransaction()
//     {
//         if (!HasLastTransaction || LastTransaction == null)
//         {
//             Console.WriteLine("No transaction available. Please create a new transaction first.");
//             return;
//         }

//         Console.WriteLine("\nLast Transaction ");
//         Console.WriteLine($"InvoiceNo: {LastTransaction.InvoiceNo}");
//         Console.WriteLine($"Customer: {LastTransaction.CustomerName}");
//         Console.WriteLine($"Item: {LastTransaction.ItemName}");
//         Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
//         Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount:F2}");
//         Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount:F2}");
//         Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
//         Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
//         Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
//         Console.WriteLine("--------------------------------------------");
//         Console.WriteLine("---------------------------------");
//     }
//     public static void RecalculateProfitLoss()
//     {
//         if (!HasLastTransaction || LastTransaction == null)
//         {
//             Console.WriteLine("No transaction available. Please create a new transaction first.");
//             return;
//         }

//         CalculateProfitLoss(LastTransaction);

//         Console.WriteLine("\nRecalculated Profit/Loss:");
//         Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
//         Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
//         Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
//         Console.WriteLine("------------------------------------------------------");
//     }
//     private static void CalculateProfitLoss(SaleTransaction t)
//     {
//         if (t.SellingAmount > t.PurchaseAmount)
//         {
//             t.ProfitOrLossStatus = "PROFIT";
//             t.ProfitOrLossAmount = t.SellingAmount - t.PurchaseAmount;
//         }
//         else if (t.SellingAmount < t.PurchaseAmount)
//         {
//             t.ProfitOrLossStatus = "LOSS";
//             t.ProfitOrLossAmount = t.PurchaseAmount - t.SellingAmount;
//         }
//         else
//         {
//             t.ProfitOrLossStatus = "BREAK-EVEN";
//             t.ProfitOrLossAmount = 0;
//         }

//         t.ProfitMarginPercent =
//             (t.ProfitOrLossAmount / t.PurchaseAmount) * 100;
//     }
//     private static string ReadName(string message)
//     {
//         while (true)
//         {
//             Console.Write(message);
//             string input = Console.ReadLine();

//             bool valid = true;

//             if (string.IsNullOrWhiteSpace(input))
//             {
//                 valid = false;
//             }
//             else
//             {
//                 foreach (char c in input)
//                 {
//                     if (!char.IsLetter(c) && c != ' ')
//                     {
//                         valid = false;
//                         break;
//                     }
//                 }
//             }

//             if (valid)
//                 return input;

//             Console.WriteLine("Invalid input. Only alphabets and spaces are allowed.");
//         }
//     }
//     private static decimal ReadDecimal(string message, bool mustBePositive)
//     {
//         decimal value;

//         while (true)
//         {
//             Console.Write(message);
//             bool ok = decimal.TryParse(Console.ReadLine(), out value);

//             if (!ok)
//             {
//                 Console.WriteLine("Invalid number. Try again.");
//                 continue;
//             }

//             if (mustBePositive && value <= 0)
//             {
//                 Console.WriteLine("Value must be greater than 0.");
//                 continue;
//             }

//             if (!mustBePositive && value < 0)
//             {
//                 Console.WriteLine("Value cannot be negative.");
//                 continue;
//             }

//             return value;
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         bool running = true;

//         while (running)
//         {
//             Console.WriteLine("\nQuickMart Traders ");
//             Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
//             Console.WriteLine("2. View Last Transaction");
//             Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your option: ");

//             string choice = Console.ReadLine()!;

//             switch (choice)
//             {
//                 case "1":
//                     TransactionService.CreateNewTransaction();
//                     break;
//                 case "2":
//                     TransactionService.ViewLastTransaction();
//                     break;
//                 case "3":
//                     TransactionService.RecalculateProfitLoss();
//                     break;
//                 case "4":
//                     Console.WriteLine("\nThank you. Application closed normally.");
//                     running = false;
//                     break;
//                 default:
//                     Console.WriteLine("Invalid option. Please select between 1 and 4.");
//                     break;
//             }
//         }
//     }
// }



//Enterprise Data Processing & Control System

using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Task 1
        Console.WriteLine("Task1: Dynamic Product Price Analysis:");
        int productCount;
        Console.Write("enetr no. of products: ");
        productCount=int.Parse(Console.ReadLine());
        int[] prices = new int[productCount];
        int sum=0;

        for(int i = 0; i < prices.Length; i++)
        {
            int price;
            do
            {
                Console.Write($"Enetr pos price for products{i}: ");
                price=int.Parse(Console.ReadLine());
            }while (price<=0);
            prices[i]=price;
            sum+=price;
        }

        double averagePrice=(double)sum/prices.Length;
        Array.Sort(prices);

        for(int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < averagePrice)
            {
                prices[i]=0;
            }
        }

        int oldSize=prices.Length;
        Array.Resize(ref prices, oldSize+5);
        for(int z = oldSize; z < prices.Length; z++)
        {
            prices[z]=(int) averagePrice;
        }

        Console.WriteLine("Final product price array: ");
        for(int z = 0; z < prices.Length; z++)
        {
            Console.WriteLine($"Index {z}: {prices[z]}");
        }  
            //Task2
            Console.WriteLine("Task2: Branch Sales Analysis");
            Console.Write("Enter no. of branches: ");
            int branches=int.Parse(Console.ReadLine());
            Console.Write("Enter no. of months: ");
            int months=int.Parse(Console.ReadLine());
            int[,] sales = new int[branches, months];
            int highestSale = int.MinValue;
            for (int i=0;i<branches;i++){
                for (int j=0;j<months;j++)
                {
                    Console.Write($"Enter sales for Branch {i}, Month {j}: ");
                    sales[i, j] = int.Parse(Console.ReadLine());
                    if(sales[i, j] > highestSale)
                    highestSale = sales[i, j];
                }
            }
            for (int i=0;i<branches;i++)
            {
            int branchTotal = 0;
            for (int j=0;j<months;j++)
            {
                branchTotal += sales[i, j];
            }
            Console.WriteLine($"Total sales of Branch {i}: {branchTotal}");
            }
            Console.WriteLine($"Highest Monthly Sale Across All Branches: {highestSale}");

            //Task3
            Console.WriteLine("TASK 3: PERFORMANCE-BASED DATA EXTRACTION (JAGGED ARRAY)");
            int[][] jaggedSales = new int[branches][];
            for(int i=0;i<branches;i++)
            {
            int count = 0;
            for(int j=0;j<months;j++)
            {
                if(sales[i,j]>=averagePrice)
                    count++;
            }
            jaggedSales[i] = new int[count];
            int index = 0;
            for(int j=0;j<months;j++)
            {
                if(sales[i, j]>=averagePrice)
                {
                    jaggedSales[i][index] = sales[i, j];
                    index++;
                }
            }
            }
            for(int i=0;i<jaggedSales.Length;i++)
            {
            Console.Write($"Branch {i}: ");
            for (int j=0;j<jaggedSales[i].Length;j++)
            {
                Console.Write(jaggedSales[i][j] + " ");
            }
            Console.WriteLine();
            }
            Console.WriteLine("TASK 3: PERFORMANCE-BASED DATA EXTRACTION (JAGGED ARRAY)");
            int[][] jaggedSales1 = new int[branches][];
            for (int i = 0; i < branches; i++)
            {
            int count = 0;
            for (int j=0;j<months;j++)
            {
                if(sales[i, j]>=averagePrice)
                    count++;
            }
            jaggedSales1[i] = new int[count];
            int index = 0;
            for (int j = 0; j < months; j++)
            {
                if(sales[i, j]>=averagePrice)
                {
                    jaggedSales1[i][index] = sales[i, j];
                    index++;
                }
            }
            }   
            for (int i=0;i<jaggedSales1.Length;i++)
            {
            Console.Write($"Branch {i}: ");
            for (int j=0;j<jaggedSales1[i].Length;j++)
            {
                Console.Write(jaggedSales1[i][j] + " ");
            }
            Console.WriteLine();
            }

            //Task4
            Console.WriteLine("TASK 4: CUSTOMER TRANSACTION CLEANING");
            Console.Write("Enter number of customer transactions: ");
            int txCount=int.Parse(Console.ReadLine());
            List<int> customerList=new List<int>();
            for (int i=0;i<txCount;i++)
            {
            Console.Write($"Enter Customer ID {i}: ");
            customerList.Add(int.Parse(Console.ReadLine()));
            }
            int originalCount = customerList.Count;
            HashSet<int> uniqueCustomers = new HashSet<int>(customerList);
            List<int> cleanedList = new List<int>(uniqueCustomers);
            Console.WriteLine("Cleaned Customer IDs:");
            foreach (int id in cleanedList)
            Console.Write(id + " ");
            Console.WriteLine($"Duplicates Removed: {originalCount - cleanedList.Count}");

            //Task5
            Console.WriteLine("TASK 5: FINANCIAL TRANSACTION FILTERING");
            Console.Write("Enter number of financial transactions: ");
            int finCount = int.Parse(Console.ReadLine());
            Dictionary<int, double> transactions = new Dictionary<int, double>();
            for (int i=0;i<finCount;i++)
            {
            Console.Write("Enter Transaction ID: ");
            int id = int.Parse(Console.ReadLine());
            if (transactions.ContainsKey(id))
            {
                Console.WriteLine("Duplicate ID not allowed.");
                i--;
                continue;
            }
            Console.Write("Enter Amount: ");
            double amt = double.Parse(Console.ReadLine());
            transactions.Add(id, amt);
            }
            SortedList<int, double> highValueTx = new SortedList<int, double>();
            foreach (KeyValuePair<int, double> kv in transactions)
            {
            if (kv.Value >= averagePrice)
                highValueTx.Add(kv.Key, kv.Value);
            }
            Console.WriteLine("High Value Transactions:");
            foreach (KeyValuePair<int, double> kv in highValueTx)
            {
            Console.WriteLine($"ID: {kv.Key}, Amount: {kv.Value}");
            }

            //Task6
            Console.WriteLine("TASK 6: PROCESS FLOW MANAGEMENT");
            Console.Write("Enter number of operations: ");
            int ops = int.Parse(Console.ReadLine());
            Queue<string> processQueue = new Queue<string>();
            Stack<string> undoStack = new Stack<string>();
            for (int i=0;i<ops;i++)
            {
            Console.Write("Enter operation: ");
            string op = Console.ReadLine();
            processQueue.Enqueue(op);
            undoStack.Push(op);
            }
            Console.WriteLine("Processed Operations:");
            while (processQueue.Count > 0)
            {
            Console.WriteLine(processQueue.Dequeue());
            }
            Console.WriteLine("Undo Operations:");
            for (int i = 0; i < 2 && undoStack.Count > 0; i++)
            {
            Console.WriteLine(undoStack.Pop());
            }

            //Task7
            Console.WriteLine("TASK 7: LEGACY DATA RISK DEMONSTRATION");
            Console.Write("Enter number of users: ");
            int users = int.Parse(Console.ReadLine());
            Hashtable userTable = new Hashtable();
            ArrayList legacyList = new ArrayList();
            for (int i = 0; i < users; i++)
            {
            Console.Write("Enter username: ");
            string name = Console.ReadLine();
            Console.Write("Enter role: ");
            string role = Console.ReadLine();
            userTable.Add(name, role);
            legacyList.Add(name);
            legacyList.Add(role);
            legacyList.Add(100); 
            }
            Console.WriteLine("Hashtable Data:");
            foreach (DictionaryEntry entry in userTable)
            {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
            }
            Console.WriteLine("ArrayList Data (Mixed Types):");
            foreach (object obj in legacyList)
            {
            Console.WriteLine(obj);
            }
            Console.WriteLine("Risk: ArrayList allows mixed data types causing runtime casting errors.");
    }
}