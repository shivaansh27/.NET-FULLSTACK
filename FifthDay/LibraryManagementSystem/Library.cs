using System;
using LibItems = LibrarySystem.Items;
enum UserRole{
    Admin,
    Librarian,
    Member
};

enum ItemStatus
{
    Avaliable,
    Borrowed,
    Reserved,
    Lost
};
partial class LibraryAnalytics
{
    public static int BorrowedItems{get; set;}
    public static int IncreaseBorrowedItems()
    {
        BorrowedItems +=1;
    }
}
partial class LibraryAnalytics
{
    public static void DisplayBorrowedItems()
    {
        Console.WriteLine(BorrowedItems);
    }
}
namespace LibrarySystem{
interface IReservable
{
    public void reserve();
}
interface INotifiable
{
    public void acceptMessage();
}
abstract class LibraryItem
{
    public string title{get; set;}
    public string author{get; set;}
    public int itemId{get; set;}

    public abstract void DisplayItem();
    public abstract double LateFee(int daysLate);

    
}

namespace Items{
class Book : LibraryItem, IReservable, INotifiable
{
    public override void DisplayItem()
    {
        Console.WriteLine($"Title: {title}\nAuthor: {author}\nItemId: {itemId}");
    }
    public override double LateFee(int daysLate)
    {
        return daysLate * 1;
    }
    void IReservable.reserve()
    {
        Console.WriteLine("Reservation Succesful.");
    }
    void INotifiable.acceptMessage()
    {
        Console.WriteLine("Notification Sent");
    }
}

class Magazine : LibraryItem
{
    public override void DisplayItem()
    {
        Console.WriteLine($"Title: {title}\nAuthor: {author}\nItemId: {itemId}");
    }
    public override double LateFee(int daysLate)
    {
        return daysLate * 0.5;
    }
}
}
namespace Users
    {
        class Member
        {
            public string name{get; set;}
        }
    }
}

