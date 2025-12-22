//using System;

//namespace myFirst
//{
//    class OrderPayment
//    {
//        public string customerName;
//        public string productName;
//        private double productPrice;
//        private double tax = 0.08;
//        private double processingFee = 25;
//        private double totalPayableAmount;

        
//        public OrderPayment(string customerName, string productName, double productPrice)
//        {
//            this.customerName = customerName;
//            this.productName = productName;
//            this.productPrice = productPrice;
//        }

       
//        private void ProcessPayment()
//        {
//            double taxAmount = productPrice * tax;
//            totalPayableAmount = productPrice + taxAmount + processingFee;

//            Console.WriteLine("Customer Name: " + customerName);
//            Console.WriteLine("Product Name: " + productName);
//            Console.WriteLine("Product Price: " + productPrice);
//            Console.WriteLine("Tax (8%): " + taxAmount);
//            Console.WriteLine("Processing Fee: " + processingFee);
//            Console.WriteLine("Total Amount Payable: " + totalPayableAmount);
           
//        }

      
//        public void PlaceOrder()
//        {
//            ProcessPayment(); 
//        }
//    }

//    internal class abstraction_shopping_example
//    {
//        static void Main(string[] args)
//        {
//            OrderPayment order1 = new OrderPayment("Jayant", "Laptop", 40000);
//            order1.PlaceOrder();


//            Console.ReadLine();
//        }
//    }
//}
