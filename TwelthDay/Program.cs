using System;
using System.Text;
class Program
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World ");
        Console.WriteLine(sb.ToString());
        sb.AppendLine("NewLine");
        Console.WriteLine(sb.ToString());
        sb.Insert(0,"Bye ");
        Console.WriteLine(sb.ToString());
        sb.Remove(0,4);
        Console.WriteLine(sb.ToString());
        sb.Replace("NewLine","Shivansh");
        Console.WriteLine(sb.ToString());
        sb.Clear();
        Console.WriteLine(sb.ToString());
    }
}