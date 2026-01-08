using System;
using System.IO;

class User
{
    public int id;
    public string name;
}
class Program
{
    public static void Main()
    {
        // string path = "data.txt";
        // File.WriteAllText(path, "File I/O Example in C# Wihout Creating a New File"); //replace all text and also create a new file if the specified file is not there
        // Console.WriteLine("Data written to the file.");

        // string content = File.ReadAllText("data.txt");
        // Console.WriteLine($"File Content: {content}");

        // using (StreamWriter writer = new StreamWriter("data.txt"))
        // {
        //     writer.WriteLine("Application Started");
        //     writer.WriteLine("Processing Data");
        //     writer.WriteLine("Application Ended");
        // }

        // using (StreamReader reader = new StreamReader("data.txt"))
        // {
        //     string line;
        //     while((line = reader.ReadLine()) != null)
        //     {
        //         Console.WriteLine(line);
        //     }
        // }

        // User user = new User {id = 1, name = "Alice"};
        // using(StreamWriter writer = new StreamWriter("log.txt"))
        // {
        //     writer.WriteLine(user.id);
        //     writer.WriteLine(user.name);
        //     user.id = 2;
        //     user.name = "Bob";
        //     writer.WriteLine(user.id);
        //     writer.WriteLine(user.name);
        // }
        // Console.WriteLine("Done");
        User user = new User();
        using(StreamReader reader = new StreamReader("log.txt"))
        {
            user.id = int.Parse(reader.ReadLine());
            user.name = reader.ReadLine();
        }
        Console.WriteLine($"UserId: {user.id} Name: {user.name}");
    }
}