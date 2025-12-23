using System;
interface IPrintable
{
    void Print();
    static int dighit = 10;
}

class Report : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing report");
    }
}
