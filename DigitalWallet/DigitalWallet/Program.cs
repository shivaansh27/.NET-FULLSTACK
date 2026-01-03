using System;
using DigitalWallet.Core;

namespace DigitalWalletApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WalletData wallet = new WalletData();

            wallet.UserId = 101;
            wallet.UserName = "Amit";
            wallet.Balance = 5000.50m;
            wallet.IsActive = true;

            wallet.RecentTransactions = new decimal[3];
            wallet.RecentTransactions[0] = 500;
            wallet.RecentTransactions[1] = 1200;
            wallet.RecentTransactions[2] = 300;

            Console.WriteLine("User Name: " + wallet.UserName);
            Console.WriteLine("Balance: " + wallet.Balance);
            Console.WriteLine("Wallet Active: " + wallet.IsActive);

            Console.WriteLine("Recent Transactions:");
            for (int i = 0; i < wallet.RecentTransactions.Length; i++)
            {
                Console.WriteLine(wallet.RecentTransactions[i]);
            }

            WalletData wallet2 = new WalletData();
            wallet2.RecentTransactions = new decimal[2];
            wallet2.RecentTransactions[0] = 200;
            wallet2.RecentTransactions[1] = 300;

            decimal[] copiedTransactions = wallet2.RecentTransactions;
            copiedTransactions[0] = 999;

            Console.WriteLine("Original Transaction Value: " + wallet2.RecentTransactions[0]); //
            Console.WriteLine("Copied Transaction Value: " + copiedTransactions[0]);

        }
    }
}
