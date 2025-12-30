using System;
using System.Text;
using System.Text.RegularExpressions;
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

        List<string> Emails = new List<string>
        {
            "john.doe@gmail.com",
            "alice_123@yahoo.in",
            "mark.smith@company.com",
            "support-abc@banking.co.in",
            "user.nametag@domain.org",
            "john.doe@gmail",         
            "alice@@yahoo.com",
            "mark.smith@.com",        
            "support@banking..com",    
            "user name@gmail.com",     
            "@domain.com",            
            "admin@domain",           
            "info@domain,com",         
            "finance#dept@corp.com",  
            "plainaddress"             

        };
        string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
         foreach (string email in Emails)
        {
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine($"Valid:   {email}");
            }
            else
            {
                Console.WriteLine($"Invalid: {email}");
            }
        }
    }
}