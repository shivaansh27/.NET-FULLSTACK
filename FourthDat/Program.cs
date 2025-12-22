using System;
class Program
{
    public static void Main()
    {
        Student s1 = new Student();
        s1.Name = "Rahul";
        s1.Age = 21;
        s1.Marks = 25;
        s1.Student_Id = 101;
        s1.Password = "abc123";
        Console.WriteLine("Name: " + s1.Name);
        Console.WriteLine("Age: " + s1.Age);
        Console.WriteLine("Marks: " + s1.Marks);
        Console.WriteLine("Result: " + s1.Result);

    }
}