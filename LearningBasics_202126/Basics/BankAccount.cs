using System;
using System.Collections.Generic;
using System.Text;

namespace LearningBasics_202126.Basics
{
    class BankAccount
    {
        private int accountNumber;
        private string accountHolder;
        private int accountBalance;
        private int depositAmount;
        private int withdrawalAmount;

        public string AccountHolder { get { return this.accountHolder; } }
        public int AccountBalance { get { return this.accountBalance; } }

        public BankAccount(string accountHolder, int initialDeposit)
        {
            this.accountHolder = accountHolder;
            if (initialDeposit > 0)
            { 
                this.accountBalance += initialDeposit; 
            }
            else 
            { 
                throw new ArgumentOutOfRangeException("initial Deposit can not be smaller then 0"); 
            }
        }
        
        public void deposit(int depositAmount)
        {
            this.depositAmount = depositAmount;
            if (this.depositAmount >= 1)
            {
                this.accountBalance += this.depositAmount;
                Console.WriteLine($"deposit of {this.depositAmount} is successfull ");
            }
            else
            {
                Console.WriteLine($"deposit amount can not be smaller then 1");
            }
        }

        public void withdrawal(int withdrawalAmount)
        {
            this.withdrawalAmount = withdrawalAmount;
            if (this.accountBalance >= this.withdrawalAmount)
            {
                this.accountBalance -= this.withdrawalAmount;
                Console.WriteLine($"withdrawal of {this.withdrawalAmount} is successfull ");
            }
            else
            {
                Console.WriteLine($" Invalid Withdrawal Amount : {this.withdrawalAmount} is greater then available Account Balance");
            }
        }

        public int retunAccuntNumber() 
        {
            var random = new Random();
            this.accountNumber = random.Next(1, 1000000000) * 2 + 1;
            return this.accountNumber;
        }

        public int checkAccountBalance()
        {
            return this.AccountBalance;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================================================");
            BankAccount account1 = new BankAccount("Ravi",2000);

            Console.WriteLine($"Account Holder - {account1.AccountHolder}");
            Console.WriteLine($"Account Number - {account1.retunAccuntNumber()}");
            Console.WriteLine($"Account Balance - {account1.checkAccountBalance()}");
            account1.deposit(21000);
            Console.WriteLine($"Account Balance - {account1.checkAccountBalance()}");
            account1.withdrawal(100);
            Console.WriteLine($"Account Balance - {account1.checkAccountBalance()}");
            account1.withdrawal(27000);
            Console.WriteLine("=====================================================================================");

            BankAccount account2 = new BankAccount("Shwetha", 2000);

            Console.WriteLine($"Account Holder - {account2.AccountHolder}");
            Console.WriteLine($"Account Number - {account2.retunAccuntNumber()}");
            Console.WriteLine($"Account Balance - {account2.checkAccountBalance()}");
            account2.deposit(50000);
            Console.WriteLine($"Account Balance - {account2.checkAccountBalance()}");
            account2.withdrawal(30000);
            Console.WriteLine($"Account Balance - {account2.checkAccountBalance()}");

        }
    }

}
