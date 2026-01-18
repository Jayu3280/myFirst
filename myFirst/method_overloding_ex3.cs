using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class method_overloding_ex3
    {
        public void Pay(int amount)
        {
            Console.WriteLine("\n--- Cash Payment ---");
            Console.WriteLine("Amount Paid : ₹" + amount);
            Console.WriteLine("Payment Mode: Cash");
            

        }

        public void Pay(int amount, string cardType)
        {
            Console.WriteLine("\n--- Card Payment ---");
            Console.WriteLine("Amount Paid : ₹" + amount);
            Console.WriteLine("Card Type   : " + cardType);
            Console.WriteLine("Payment Mode: Card");


        }

        public void Pay(int amount, string upiApp , bool isUpi)
        {
            Console.WriteLine("\n--- UPI Payment ---");
            Console.WriteLine("Amount Paid : ₹" + amount);
            Console.WriteLine("UPI App     : " + upiApp);
            Console.WriteLine("Payment Mode: UPI");

        }



        static void Main(string[] args)
        {
            method_overloding_ex3 s = new method_overloding_ex3();

            Console.WriteLine("Choose Payment Method:");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Card");
            Console.WriteLine("3. UPI");

            Console.Write("Select Your Menu: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    s.Pay(amount);
                    break;

                case 2:
                    Console.Write("Enter card type (VISA / MASTER): ");
                    string cardType = Console.ReadLine();
                    s.Pay(amount, cardType);
                    break;

                case 3:
                    Console.Write("Enter UPI App (Google Pay / PhonePe): ");
                    string upiApp = Console.ReadLine();
                    s.Pay(amount, upiApp, true);
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.ReadLine();

        }
    }
}
