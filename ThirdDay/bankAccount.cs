using System;
// class BankAccount
// {
//    public double balance;
//     public int acc_no;

//     static BankAccount(double balance, int acc_no)
//     {
//         this.balance = balance;
//         this.acc_no = acc_no;
//     }
// }

// class FixedDeposit : BankAccount
// {
//     public int time;
//     public double roi;
//     public double fdamt;
//     public FixedDeposit(int time, double roi, double fdamt) : base(40000, 101)
//     {
//         this.time = time;
//         this.roi = roi;
//         this.fdamt = fdamt;
//     }
//     public void runFunc()
//     {
//         Console.WriteLine($"Your acc no is: {acc_no} and your balance is: {balance}. {time} {roi} {fdamt}" );
//     }
// }
class Product
{
    public string Name;
    public int Price;

    public Product() { }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}