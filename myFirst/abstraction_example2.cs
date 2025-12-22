using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class abstraction_example2
    {
        abstract class payment
        {
            public double amount;
            public string CustomerName;

            public void ShowBasicInfo()
            {
                Console.WriteLine($"CustomerName : {CustomerName} , Amount : {amount}");
            }

            public abstract void ProcessPayment();  //abstract method


        }
        class CreditCardPayment : payment
        {
            public string cardNumber;

            public override void ProcessPayment()
            {
                Console.WriteLine($"processing creditcard payment using {cardNumber}");
                Console.WriteLine($"Creditcard payment Succefully");
            }
        }

        class UPiPayment : payment
        {
            public string upiId;

            public override void ProcessPayment()
            {
                Console.WriteLine($"processing creditcard payment using {upiId}");
                Console.WriteLine($"Upiid payment Succefully");
            }

        }
        class NetBank : payment
        {
            public string netBank;

            public override void ProcessPayment()
            {
                Console.WriteLine($"processing creditcard payment using {netBank}");
                Console.WriteLine($"NetBank payment Succefully");
            }

        }


        static void Main(string[] args)
        {
            payment p1 = new CreditCardPayment
            {
                CustomerName = "Jayant",
                amount = 12000,
                cardNumber = "321-123-654-987"

            };
            Console.WriteLine("------Credit card payment-------");
            p1.ShowBasicInfo();
            p1.ProcessPayment();

            payment p2 = new UPiPayment
            {
                CustomerName = "Ashwini",
                amount = 1256,
                upiId = "95296678@ybl"

            };
            Console.WriteLine("------Upiid payment-------");
            p2.ShowBasicInfo();
            p2.ProcessPayment();

            payment p3 = new NetBank
            {
                CustomerName = "Gajanan",
                amount = 15000,
               netBank = "9462010005669"

            };
            Console.WriteLine("------NetBank payment-------");
            p3.ShowBasicInfo();
            p3.ProcessPayment();

            Console.ReadLine();
        }
    }
}
