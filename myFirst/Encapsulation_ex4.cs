using myFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class ShoppingCart
    {
        private double TotalAmount = 0;

        public void AddItem(double price)
        {
            if (price > 0)
            {
                TotalAmount += price;
                Console.WriteLine($"Item Added Price : {price}");
            }
            else
            {
                Console.WriteLine("Invalid Item Price .");
            }
        }
        public void GetTotalAmount()
        {
            Console.WriteLine($"Total Amount in Shopping Cart : {TotalAmount}");
        }
    }

}
    internal class Encapsulation_ex4
    {
        static void Main(string[] args)
        {
       
            ShoppingCart s = new ShoppingCart();

           
            s.AddItem(150);       
            s.AddItem(200);    
            s.AddItem(-50);   
        
            s.GetTotalAmount();
          Console.ReadLine();

           
            

        }
    }


