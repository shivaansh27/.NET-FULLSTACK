using System;
using System.Text;
using System.Text.RegularExpressions;
using LogProcessing;
class Program
{
    public static void Main()
    {
        //string Sentence = "@123_123";
        // string pattern = @"\d";
        // string Sentence = "123_123";
        // string pattern = @"\d*";
        // string pattern = @"\w";
        // string pattern = @"\W";
        // string pattern = @"\s";
        // string pattern = @"\S";
        // string pattern = @"\.txt";
        // string pattern = @"lo$";
        // string pattern = "@Hello$";
        // string pattern = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";
        // string pattern = @"a...e";
        // string Sentence = "Amount: 5000";
        // string Sentence = "10A20B30C!@_abc _0!\t file.txt";'
        // string Sentence = "Hello";
        // string Sentence = "2025-12-29";
        // string Sentence = "1992/02/03, 1990-01-01, 2025";
        // string Sentence= "a123e, apples, a!-@e frappe grapple";
        // bool result = Regex.Match(Sentence,pattern);
        // MatchCollection m = Regex.Matches(Sentence,pattern);
        // foreach(Match a in m)
        // {
        //     Console.WriteLine(a);
        // }
        // MatchCollection math = Regex.Matches(Sentence,pattern);
        // foreach(Match m in math)
        // {
        //     Console.WriteLine(m.Groups[2].Value);
        // }
        // MatchCollection matches = Regex.Matches(Sentence,pattern);
        // foreach(Match m in matches)
        // {
        //     Console.WriteLine(m);
        // }

        // List<string> Emails = new List<string>
        // {
        //     "john.doe@gmail.com",
        //     "alice_123@yahoo.in",
        //     "mark.smith@company.com",
        //     "support-abc@banking.co.in",
        //     "user.nametag@domain.org",
        //     "john.doe@gmail",         
        //     "alice@@yahoo.com",
        //     "mark.smith@.com",        
        //     "support@banking..com",    
        //     "user name@gmail.com",     
        //     "@domain.com",            
        //     "admin@domain",           
        //     "info@domain,com",         
        //     "finance#dept@corp.com",  
        //     "plainaddress"             

        // };
        // string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
        //  foreach (string email in Emails)
        // {
        //     if (Regex.IsMatch(email, pattern))
        //     {
        //         Console.WriteLine($"Valid:   {email}");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Invalid: {email}");
        //     }
        // }
        LogParser parser = new LogParser();

        Console.WriteLine("Task 1: Validate Log Line Format");

        string[] logLines =
        {
            "[INF] Application started",
            "[ERR] Database connection failed",
            "[WRN] Low memory warning",
            "INF Application started",
            "[INFO] Application started",
            "[ABC] Unknown message"
        };

        foreach (string line in logLines)
        {
            Console.WriteLine($"{line} -> {parser.IsValidLine(line)}");
        }

        Console.WriteLine();
        Console.WriteLine("Task 2: Split Log Line Using Delimiters");

        string splitInput = "[INF] User login<***>Session created<====>Access granted";
        string[] splitResult = parser.SplitLogLine(splitInput);

        foreach (string part in splitResult)
        {
            Console.WriteLine(part);
        }

        Console.WriteLine();
        Console.WriteLine("Task 3: Count Quoted Password Occurrences");

        string passwordLogs =
            "User said \"password123 is weak\"\n" +
            "Admin noted \"PASSWORD456 expired\"\n" +
            "No issue found";

        Console.WriteLine(parser.CountQuotedPasswords(passwordLogs));

        Console.WriteLine();
        Console.WriteLine("Task 4: Remove End-of-Line Markers");

        string endLineInput = "Transaction completed successfully end-of-line456";
        Console.WriteLine(parser.RemoveEndOfLineText(endLineInput));

        Console.WriteLine();
        Console.WriteLine("Task 5: Identify and Label Weak Passwords");

        string[] passwordLines =
        {
            "User entered password123 during login",
            "System startup completed",
            "Admin reset passwordABC",
            "Backup process finished"
        };

        string[] labeledLines = parser.ListLinesWithPasswords(passwordLines);

        foreach (string line in labeledLines)
        {
            Console.WriteLine(line);
        }
    }
}