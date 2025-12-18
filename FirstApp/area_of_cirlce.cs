using System;

class AOC
{
    public static void area_of_circle()
    {
         Console.Write("Enter radius: ");
        double r= Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * r * r;
        Console.WriteLine("Area of circle is: "+area);
        Console.WriteLine(Math.PI);

    }
}