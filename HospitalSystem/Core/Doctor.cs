using System;
class Doctor
{
    public string name{get; set;}
    public string specialization{get; set;}
    private readonly int licenseno;
    public static int totaldoctors;

    static Doctor()
    {
        totaldoctors = 0;
        Console.WriteLine("Static Constructor");
    }

    public Doctor(string name, int licenseno, string specialization)
    {
        this.name = name;
        this.licenseno = licenseno;
        this.specialization = specialization;
        totaldoctors++;
    }
}