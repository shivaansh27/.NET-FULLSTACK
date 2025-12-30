using System;

// class PatientBill
// {
//     public string BillId { get; set; }
//     public string PatientName { get; set; }
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
//     private static PatientBill lastBill;

//     public static void CreateNewBill()
//     {
//         PatientBill bill = new PatientBill();

//         while (true)
//         {
//             Console.Write("Enter Bill Id: ");
//             bill.BillId = Console.ReadLine();
//             if (!string.IsNullOrWhiteSpace(bill.BillId))
//                 break;
//             Console.WriteLine("Bill Id cannot be empty.");
//         }

//         bill.PatientName = ReadName("Enter Patient Name: ");
//         bill.HasInsurance = ReadYesNo("Is the patient insured? (Y/N): ");

//         bill.ConsultationFee = ReadDecimal("Enter Consultation Fee: ", true);
//         bill.LabCharges = ReadDecimal("Enter Lab Charges: ", false);
//         bill.MedicineCharges = ReadDecimal("Enter Medicine Charges: ", false);

//         bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;
//         bill.DiscountAmount = bill.HasInsurance ? bill.GrossAmount * 0.10m : 0;
//         bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

//         lastBill = bill;

//         Console.WriteLine("\nBill created successfully");
//         Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
//         Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
//         Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
//     }

//     public static void ViewLastBill()
//     {
//         if (lastBill == null)
//         {
//             Console.WriteLine("No bill available.");
//             return;
//         }

//         Console.WriteLine("\nLast Bill");
//         Console.WriteLine($"Bill Id: {lastBill.BillId}");
//         Console.WriteLine($"Patient Name: {lastBill.PatientName}");
//         Console.WriteLine($"Insured: {(lastBill.HasInsurance ? "Yes" : "No")}");
//         Console.WriteLine($"Consultation Fee: {lastBill.ConsultationFee:F2}");
//         Console.WriteLine($"Lab Charges: {lastBill.LabCharges:F2}");
//         Console.WriteLine($"Medicine Charges: {lastBill.MedicineCharges:F2}");
//         Console.WriteLine($"Final Payable: {lastBill.FinalPayable:F2}");
//     }

//     public static void ClearLastBill()
//     {
//         lastBill = null;
//         Console.WriteLine("Last bill cleared.");
//     }

//     private static string ReadName(string message)
//     {
//         while (true)
//         {
//             Console.Write(message);
//             string input = Console.ReadLine();

//             if (!string.IsNullOrWhiteSpace(input))
//             {
//                 bool valid = true;
//                 foreach (char c in input)
//                 {
//                     if (!char.IsLetter(c) && c != ' ')
//                     {
//                         valid = false;
//                         break;
//                     }
//                 }
//                 if (valid)
//                     return input;
//             }

//             Console.WriteLine("Invalid name.");
//         }
//     }

//     private static bool ReadYesNo(string message)
//     {
//         while (true)
//         {
//             Console.Write(message);
//             string input = Console.ReadLine().ToUpper();
//             if (input == "Y") return true;
//             if (input == "N") return false;
//             Console.WriteLine("Please enter Y or N.");
//         }
//     }

//     private static decimal ReadDecimal(string message, bool mustBePositive)
//     {
//         while (true)
//         {
//             Console.Write(message);
//             if (decimal.TryParse(Console.ReadLine(), out decimal value))
//             {
//                 if (mustBePositive && value <= 0) continue;
//                 if (!mustBePositive && value < 0) continue;
//                 return value;
//             }
//             Console.WriteLine("Invalid number.");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("\nMediSure Clinic Billing");
//             Console.WriteLine("1. Create New Bill");
//             Console.WriteLine("2. View Last Bill");
//             Console.WriteLine("3. Clear Last Bill");
//             Console.WriteLine("4. Exit");
//             Console.Write("Choose option: ");

//             switch (Console.ReadLine())
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
//                     return;
//                 default:
//                     Console.WriteLine("Invalid choice.");
//                     break;
//             }
//         }
//     }
// }


class SaleTransaction
{
    public string InvoiceNo { get; set; }
    public string CustomerName { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public decimal PurchaseAmount { get; set; }
    public decimal SellingAmount { get; set; }
    public string Status { get; set; }
    public decimal Difference { get; set; }
    public decimal Margin { get; set; }
}

class TransactionService
{
    private static SaleTransaction lastTransaction;

    public static void CreateTransaction()
    {
        SaleTransaction t = new SaleTransaction();

        t.InvoiceNo = ReadText("Enter Invoice No: ");
        t.CustomerName = ReadName("Enter Customer Name: ");
        t.ItemName = ReadName("Enter Item Name: ");
        t.Quantity = ReadInt("Enter Quantity: ");

        t.PurchaseAmount = ReadDecimal("Enter Purchase Amount: ");
        t.SellingAmount = ReadDecimal("Enter Selling Amount: ");

        Calculate(t);
        lastTransaction = t;

        PrintSummary(t);
    }

    public static void ViewLastTransaction()
    {
        if (lastTransaction == null)
        {
            Console.WriteLine("No transaction available.");
            return;
        }
        PrintSummary(lastTransaction);
    }

    public static void Recalculate()
    {
        if (lastTransaction == null)
        {
            Console.WriteLine("No transaction available.");
            return;
        }
        Calculate(lastTransaction);
        PrintSummary(lastTransaction);
    }

    private static void Calculate(SaleTransaction t)
    {
        if (t.SellingAmount > t.PurchaseAmount)
        {
            t.Status = "PROFIT";
            t.Difference = t.SellingAmount - t.PurchaseAmount;
        }
        else if (t.SellingAmount < t.PurchaseAmount)
        {
            t.Status = "LOSS";
            t.Difference = t.PurchaseAmount - t.SellingAmount;
        }
        else
        {
            t.Status = "BREAK EVEN";
            t.Difference = 0;
        }

        t.Margin = (t.Difference / t.PurchaseAmount) * 100;
    }

    private static void PrintSummary(SaleTransaction t)
    {
        Console.WriteLine("\nTransaction Summary");
        Console.WriteLine($"Invoice: {t.InvoiceNo}");
        Console.WriteLine($"Customer: {t.CustomerName}");
        Console.WriteLine($"Item: {t.ItemName}");
        Console.WriteLine($"Quantity: {t.Quantity}");
        Console.WriteLine($"Purchase Amount: {t.PurchaseAmount:F2}");
        Console.WriteLine($"Selling Amount: {t.SellingAmount:F2}");
        Console.WriteLine($"Status: {t.Status}");
        Console.WriteLine($"Difference: {t.Difference:F2}");
        Console.WriteLine($"Margin (%): {t.Margin:F2}");
    }

    private static string ReadName(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                bool valid = true;
                foreach (char c in input)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid) return input;
            }
            Console.WriteLine("Invalid input.");
        }
    }

    private static string ReadText(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                return input;
            Console.WriteLine("Value cannot be empty.");
        }
    }

    private static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int v) && v > 0)
                return v;
            Console.WriteLine("Invalid number.");
        }
    }

    private static decimal ReadDecimal(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (decimal.TryParse(Console.ReadLine(), out decimal v) && v >= 0)
                return v;
            Console.WriteLine("Invalid amount.");
        }
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nQuickMart Traders");
            Console.WriteLine("1. New Transaction");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Recalculate Profit/Loss");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    TransactionService.CreateTransaction();
                    break;
                case "2":
                    TransactionService.ViewLastTransaction();
                    break;
                case "3":
                    TransactionService.Recalculate();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
