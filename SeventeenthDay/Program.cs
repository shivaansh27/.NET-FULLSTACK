using System;
using System.Reflection;

class Employee
{
    public string name { get; set; }
    private int _salary;

    public Employee()
    {
        name = "Default";
        _salary = 0;
    }

    public Employee(string name, int salary)
    {
        this.name = name;
        _salary = salary;
    }

    public void Work()
    {
        Console.WriteLine("Employee is Working.");
    }
}

class Program
{
    public static void Main()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        Type type = assembly.GetType("Employee");

        // -------- ConstructorInfo --------
        ConstructorInfo[] constructors = type.GetConstructors();

        Console.WriteLine("Constructors found:");
        foreach (ConstructorInfo ctor in constructors)
        {
            Console.WriteLine(ctor);

            // -------- ParameterInfo --------
            ParameterInfo[] parameters = ctor.GetParameters();

            foreach (ParameterInfo param in parameters)
            {
                Console.WriteLine(
                    $"   Parameter Name: {param.Name}, Type: {param.ParameterType}"
                );
            }
        }

        // -------- MethodInfo --------
        MethodInfo method = type.GetMethod("Work");

        object obj = Activator.CreateInstance(type);
        method.Invoke(obj, null);

        // -------- PropertyInfo --------
        PropertyInfo property = type.GetProperty("name");
        property.SetValue(obj, "Shivansh");
        Console.WriteLine($"Employee Name: {property.GetValue(obj)}");

        // -------- FieldInfo --------
        FieldInfo field = type.GetField(
            "_salary",
            BindingFlags.NonPublic | BindingFlags.Instance
        );

        field.SetValue(obj, 50000);
        Console.WriteLine($"Employee Salary: {field.GetValue(obj)}");
    }
}
