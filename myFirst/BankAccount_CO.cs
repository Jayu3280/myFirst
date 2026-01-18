using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class BankAccount101
    {
        public int accountNumber;
        public string accountHolderName;
        public double balance;

        public void Deposite(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Deposited" + amount);
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
            }
            else
            { 
                Console.WriteLine("Withdraw" + amount); 
            }
                
        }
        public void Dislpay()
        {
            Console.WriteLine("Account Number :" + accountNumber);
            Console.WriteLine("Account Holder Name : " + accountHolderName);
            Console.WriteLine("Balance : " + balance);
        }
    }
    internal class BankAccount_CO
    {
        static void Main(string[] args)
        {
            BankAccount101  acc1 = new BankAccount101();
            acc1.accountNumber = 1001;
            acc1.accountHolderName = "Jayant Patil";
            acc1.balance = 1000;

            acc1.Deposite(2000);
            acc1.Withdraw(1600);


            Console.WriteLine("====================");

            BankAccount101 acc2 = new BankAccount101();
            acc2.accountNumber = 1020;
            acc2.accountHolderName = "Ashwini Patil";
            acc2.balance = 2500;

            acc2.Deposite(1000);
            acc2.Withdraw(1200);


            acc1.Dislpay();
            Console.WriteLine("====================");
            acc2.Dislpay();

        }
    }
}
