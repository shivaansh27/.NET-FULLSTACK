using System;
using System.Collections.Concurrent;
class Program
{
    public static void Main()
    {
        LibItems.Book book = new LibItems.Book()
        {
            title = "C# Basics",
            author = "John",
            itemId = 202
        };

        LibItems.Magazine magazine = new LibItems.Magazine()
        {
            title = "Tech Monthly",
            author = "Smith",
            itemId = 202
        };

        Book b1 = new Book();

        // book.DisplayItem();
        // Console.WriteLine("Late Fee: "+book.LateFee(5));

        // magazine.DisplayItem();
        // Console.WriteLine("Late Fee: "+magazine.LateFee(5));

        // b1.reserve();
        // b1.acceptMessage();

        List<LibraryItem> L1 = new List<LibraryItem>();
        L1.Add(book);
        L1.Add(magazine);

        Console.WriteLine("Dynamic Polymorphism");
        foreach(LibraryItem item in L1)
        {
            item.DisplayItem();
        }

        IReservable p = b1;
        p.reserve();
        INotifiable n = b1;
        n.acceptMessage();
    }
}