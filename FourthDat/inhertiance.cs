using System;
// class Vehicle
// {
//     public void start()
//     {
//         Console.WriteLine("Car is starting");
//     }
// }

// class Car : Vehicle
// {
//     public void drive()
//     {
//         Console.WriteLine("Car is driving");
//     }
// }

class Person
{
    public string Name;

    public Person(String name)
    {
        Name = name;
    }
}

class Student : Person
{
    public int RollNo;

    public Student(String name,int roll) : base(name)
    {
        RollNo = roll;
    }

    public void OutPut()
    {
        Console.WriteLine($"{Name} {RollNo}");
    }
}