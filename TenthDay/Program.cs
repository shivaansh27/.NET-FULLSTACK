using System;

class PatientBill
{
    public string BillId { get; set; }
    public string PatientName { get; set; }
    public bool HasInsurance { get; set; }
    public decimal ConsultationFee { get; set; }
    public decimal LabCharges { get; set; }
    public decimal MedicineCharges { get; set; }
    public decimal GrossAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal FinalPayable { get; set; }
}

class BillingService
{
    private static PatientBill lastBill;

    public static void CreateNewBill()
    {
        PatientBill bill = new PatientBill();

        while (true)
        {
            Console.Write("Enter Bill Id: ");
            bill.BillId = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(bill.BillId))
                break;
            Console.WriteLine("Bill Id cannot be empty.");
        }

        bill.PatientName = ReadName("Enter Patient Name: ");
        bill.HasInsurance = ReadYesNo("Is the patient insured? (Y/N): ");

        bill.ConsultationFee = ReadDecimal("Enter Consultation Fee: ", true);
        bill.LabCharges = ReadDecimal("Enter Lab Charges: ", false);
        bill.MedicineCharges = ReadDecimal("Enter Medicine Charges: ", false);

        bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;
        bill.DiscountAmount = bill.HasInsurance ? bill.GrossAmount * 0.10m : 0;
        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

        lastBill = bill;

        Console.WriteLine("\nBill created successfully");
        Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
    }

    public static void ViewLastBill()
    {
        if (lastBill == null)
        {
            Console.WriteLine("No bill available.");
            return;
        }

        Console.WriteLine("\nLast Bill");
        Console.WriteLine($"Bill Id: {lastBill.BillId}");
        Console.WriteLine($"Patient Name: {lastBill.PatientName}");
        Console.WriteLine($"Insured: {(lastBill.HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {lastBill.ConsultationFee:F2}");
        Console.WriteLine($"Lab Charges: {lastBill.LabCharges:F2}");
        Console.WriteLine($"Medicine Charges: {lastBill.MedicineCharges:F2}");
        Console.WriteLine($"Final Payable: {lastBill.FinalPayable:F2}");
    }

    public static void ClearLastBill()
    {
        lastBill = null;
        Console.WriteLine("Last bill cleared.");
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
                if (valid)
                    return input;
            }

            Console.WriteLine("Invalid name.");
        }
    }

    private static bool ReadYesNo(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine().ToUpper();
            if (input == "Y") return true;
            if (input == "N") return false;
            Console.WriteLine("Please enter Y or N.");
        }
    }

    private static decimal ReadDecimal(string message, bool mustBePositive)
    {
        while (true)
        {
            Console.Write(message);
            if (decimal.TryParse(Console.ReadLine(), out decimal value))
            {
                if (mustBePositive && value <= 0) continue;
                if (!mustBePositive && value < 0) continue;
                return value;
            }
            Console.WriteLine("Invalid number.");
        }
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMediSure Clinic Billing");
            Console.WriteLine("1. Create New Bill");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    BillingService.CreateNewBill();
                    break;
                case "2":
                    BillingService.ViewLastBill();
                    break;
                case "3":
                    BillingService.ClearLastBill();
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
