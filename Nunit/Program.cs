using NUnit.Framework;
using System;

namespace BankAccountApp.Tests
{
    public class Program
    {
        public decimal Balance { get; private set; }

        public Program(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Deposit amount cannot be negative");

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds");

            Balance -= amount;
        }
    }

    [TestFixture]
    public class UnitTest
    {
        private Program _account;

        [SetUp]
        public void SetUp()
        {
            
            _account = new Program(100.0m);
        }

        [Test]
        public void Test_Deposit_ValidAmount()
        {
            
            _account.Deposit(50.0m);

           
            Assert.AreEqual(150.0m, _account.Balance);
        }

        [Test]
        public void Test_Deposit_NegativeAmount()
        {
            
            var ex = Assert.Throws<ArgumentException>(() => _account.Deposit(-50.0m));
            Assert.AreEqual("Deposit amount cannot be negative", ex.Message);
        }

        [Test]
        public void Test_Withdraw_ValidAmount()
        {
            
            _account.Withdraw(30.0m);

            
            Assert.AreEqual(70.0m, _account.Balance);
        }

        [Test]
        public void Test_Withdraw_InsufficientFunds()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => _account.Withdraw(200.0m));
            Assert.AreEqual("Insufficient funds", ex.Message);
        }
    }
}
