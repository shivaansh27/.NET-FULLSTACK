using System;
using System.Runtime.InteropServices;
using System.Text;
class Program
{
    public static void Main()
    {
        // StringBuilder sb = new StringBuilder();
        // sb.Append("Hello");
        // sb.Append(" ");
        // sb.Append("World ");
        // Console.WriteLine(sb.ToString());
        // sb.AppendLine("NewLine");
        // Console.WriteLine(sb.ToString());
        // sb.Insert(0,"Bye ");
        // Console.WriteLine(sb.ToString());
        // sb.Remove(0,4);
        // Console.WriteLine(sb.ToString());
        // sb.Replace("NewLine","Shivansh");
        // Console.WriteLine(sb.ToString());
        // sb.Clear();
        // Console.WriteLine(sb.ToString());

        // long memoryUsed1 = GC.GetTotalMemory(false);
        // Console.WriteLine("Memory used: " + memoryUsed1);

        // StringBuilder sb = new StringBuilder();
        // for(int i=0; i < 10000; i++)
        // {
        //     sb.Append(i);
        // }
        // string result = sb.ToString();

        
        // long memoryUsed = GC.GetTotalMemory(false);
        // Console.WriteLine("Memory used: " + memoryUsed);

        StringBuilder sb1 = new StringBuilder("Hello");
        StringBuilder sb2 = new StringBuilder("Hello");
        Console.WriteLine(sb1.Equals(sb2));
        Console.WriteLine(object.ReferenceEquals(sb1,sb2));
        StringBuilder sb3 = sb2;
        Console.WriteLine(sb2.Equals(sb3));
        Console.WriteLine(object.ReferenceEquals(sb2,sb3));
        // Console.WriteLine(sb3.Equals(sb2));   
        // GCHandle handle = GCHandle.Alloc(sb2,GCHandleType.Pinned);
        // IntPtr address = handle.AddrOfPinnedObject();
        // Console.WriteLine(address);
        // handle.Free();
        // Console.WriteLine(object.ReferenceEquals(sb2,sb3));
    }
}