using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class BankAccount
    {
        private string accountHolder;
        private string accountNumber;
        private double balance;


        //Account Creation

        public void CreateAccount()
        {
            Console.WriteLine("Enter Account Holder Name");
            accountHolder = Console.ReadLine();

            Console.WriteLine("Enter Account Number");
            accountNumber = Console.ReadLine();

            Console.WriteLine("Enter Opening Balance");
            balance = Convert.ToDouble(Console.ReadLine());
        }
        public void Deposite()

        {
            Console.WriteLine("Enter Deposite Ammount");
            double amount = Convert.ToDouble(Console.ReadLine());

            if(amount > 0)
            {
                balance += amount;
                Console.WriteLine("Amount Deposited Sussefully");
            }
            else
            {
                Console.WriteLine("Invalid Deposite Ammount");
            }
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter Withdraw Amount Rs :");
            double amount = Convert.ToDouble(Console.ReadLine());   // <-- THIS WAS MISSING

            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Amount Withdrawn Successfully");
            }
            else
            {
                Console.WriteLine("Insufficient Balance or Invalid Amount");
            }
        }


        public void showAccountInfo()
        {
            Console.WriteLine("-------Account Info------");
            Console.WriteLine("Account Holder Name : " + accountHolder);
            Console.WriteLine("Account Number : " + accountNumber);
            Console.WriteLine("Current Balance : " + balance);  
        }
    }
    internal class Encapsulation_ex2
    {
        static void Main(string[] args)
        {

            BankAccount acc = new BankAccount();
            acc.CreateAccount();
            acc.Deposite();
            acc.Withdraw();
            acc.showAccountInfo();
            


            Console.ReadLine();
        }
    }
}
