using System;

namespace myFirst
{
    public interface IPayment
    {
        void Pay(string from, string to, double amount);
        void SendReceipt(string to, double amount);
        void LogPayment(string method, string status, DateTime time);
    }

    class CreditCardPayment : IPayment
    {
        public void Pay(string from, string to, double amount)
        {
            Console.WriteLine($"Credit card {from} paid Rs {amount} to {to}");
        }

        public void SendReceipt(string to, double amount)
        {
            Console.WriteLine($"Sending email receipt to {to} for Rs {amount}");
        }

        public void LogPayment(string method, string status, DateTime time)
        {
            Console.WriteLine($"Log - {method}, Status: {status}, Time: {time}");
        }
    }

    class UpiPayment : IPayment
    {
        public void Pay(string from, string to, double amount)
        {
            Console.WriteLine($"UPI {from} paid Rs {amount} to {to}");
        }

        public void SendReceipt(string to, double amount)
        {
            Console.WriteLine($"Sending UPI receipt to {to} for Rs {amount}");
        }

        public void LogPayment(string method, string status, DateTime time)
        {
            Console.WriteLine($"Log - {method}, Status: {status}, Time: {time}");
        }
    }

    class CashPayment : IPayment
    {
        public void Pay(string from, string to, double amount)
        {
            Console.WriteLine($"UPI {from} paid Rs {amount} to {to}");
        }

        public void SendReceipt(string to, double amount)
        {
            Console.WriteLine($"Sending UPI receipt to {to} for Rs {amount}");
        }

        public void LogPayment(string method, string status, DateTime time)
        {
            Console.WriteLine($"Log - {method}, Status: {status}, Time: {time}");
        }
    }

    internal class interface_example_2
    {
        static void Main(string[] args)
        {
            IPayment payment1 = new CreditCardPayment();
            Console.WriteLine("------- Credit Card Payment --------");
            payment1.Pay("Jayant", "Ashwini", 25000);
            payment1.SendReceipt("Jayant", 25000);
            payment1.LogPayment("Credit Card", "Success", DateTime.Now);

            IPayment payment2 = new UpiPayment();
            Console.WriteLine("\n------- UPI Payment --------");
            payment2.Pay("Divyesh", "Gajanan", 2300);
            payment2.SendReceipt("Jayant", 2300);
            payment2.LogPayment("UPI", "Success", DateTime.Now);

            IPayment payment3 = new CashPayment();
            Console.WriteLine("\n-------Cash Payment --------");
            payment3.Pay("Divyesh", "Shree Medical", 1500);
            payment3.SendReceipt("Shree Medical", 1500);
            payment3.LogPayment("UPI", "Success", DateTime.Now);


            Console.ReadLine();
        }
    }
}
