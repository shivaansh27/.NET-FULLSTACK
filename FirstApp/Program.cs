using System;
using System.ComponentModel;
using System.Data.SqlTypes;
class Area
{
    public static void Main()
    {
        Console.Write("Enter radius: ");
        double r= Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * r * r;
        Console.WriteLine("Area of circle is: "+area);

    }
}