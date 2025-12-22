using System;

namespace myFirst
{
    internal class function_types
    {
        // No parameter, no return - static
        public static void showMessage()
        {
            Console.WriteLine("Welcome Jayant");
        }

        // No parameter, no return - non-static
        public void showMessage1()
        {
            Console.WriteLine("Welcome Divyesh (no parameter, no return - non-static)");
        }

        // With parameter, no return - static
        public static void message(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        // With parameter, no return - static
        public static void message1(string name)
        {
            Console.WriteLine("Hello " + name + " (with parameter, no return - static)");
        }

        // No parameter, with return - static
        public static int getNumber()
        {
            return 15;
        }

        // No parameter, with return - non-static (FIXED)
        public int getNumber1()
        {
            return 25;
        }

        //with parameter with , return - static
        public static int Add(int a, int b)
        {
            return a + b;
        }

        //with parameter with , return non- static
        public static int Add1(int a, int b)
        {
            return a + b;
        }


        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static void Subtraction(int a, int b)
        {
            Console.WriteLine("Subtraction is" + (a - b));
        }

        public static int multiplication()
        {
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            return a * b;
        }

        public static void Division()
        {
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Division is : " + (a / b));
        }

        static void Addition()   // static + no parameters + no return
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = a + b;
            Console.WriteLine("Result: " + result);
        }

        static void Subtraction(double a, double b)   // parameters, no return
        {
            double result = a - b;
            Console.WriteLine("Result: " + result);
        }

        static double Multiplication()  // no parameters, returns a value
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            return a * b;  // return the result

        }

        static double Division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;  // safe return value
            }
            return a / b;
        }

        static void DisplayWelcome()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Welcome, {name}!");
        }

        // 2. Show Item Details (With Parameter, No Return)
        static void ShowItemDetails(string itemName, double price)
        {
            Console.WriteLine($"\nItem Selected: {itemName}");
            Console.WriteLine($"Price: ${price}");
        }

        // 3. Calculate Item Total (No Parameter, With Return)
        static double CalculateItemTotal()
        {
            Console.Write("Enter quantity: ");
            int qty = int.Parse(Console.ReadLine());

            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            double total = price * qty;
            return total;
        }

        // 4. Apply Discount (With Parameter, With Return)
        static double ApplyDiscount(double amount)
        {
            Console.Write("Enter discount percentage: ");
            double discount = double.Parse(Console.ReadLine());

            double discountAmount = amount * (discount / 100);
            double finalAmount = amount - discountAmount;
            return finalAmount;
        }









        static void Main(string[] args)
        {
            //function_types.showMessage();       // static call

            //function_types ft = new function_types();

            //ft.showMessage1();                  // non-static call
            //function_types.message("Jayant");   // static call
            //function_types.message1("Divyesh"); // static call

            //Console.WriteLine("Number is " + getNumber());  // static
            //Console.WriteLine("Number is " + ft.getNumber1()); // non-static
            //int sum = Add(23, 56);
            //Console.WriteLine("Sum is" + sum);  //static
            //int sum1 = Add1(23, 90);
            //Console.WriteLine("Sum is" + sum1); //non static
            //Console.WriteLine("Enter 1st number (a)");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter 2nd number (b)");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int AddResult  =Addition(a ,b);
            //Console.WriteLine("Addition is " + AddResult);

            //Console.WriteLine("Enter 1st number (a)");
            //int a1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter 2nd number (b)");
            //int b1 = Convert.ToInt32(Console.ReadLine());
            //Subtraction(a1, b1);

            //int mulresult = multiplication();   // call the function

            //Console.WriteLine("Multiplication is: " + mulresult);

            //Division();



            //Addition();   // calling the static no-parameter no-return method

            //Console.Write("Enter first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Subtraction(num1, num2);  // pass user input as parameters

            //double result = Multiplication();  // call method and get returned value
            //Console.WriteLine("Result: " + result);

            //Console.Write("Enter first number: ");
            //if (!double.TryParse(Console.ReadLine(), out double num1))
            //{
            //    Console.WriteLine("Invalid input.");
            //    return;
            //}

            //Console.Write("Enter second number: ");
            //if (!double.TryParse(Console.ReadLine(), out double num2))
            //{
            //    Console.WriteLine("Invalid input.");
            //    return;
            //}

            //double result = Division(num1, num2);
            //Console.WriteLine("Result: " + result);

            // Step 1
            DisplayWelcome();

            // Step 2
            Console.Write("\nEnter item name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            ShowItemDetails(itemName, price);

            // Step 3
            Console.WriteLine("\n--- Calculate Total ---");
            double total = CalculateItemTotal();
            Console.WriteLine($"Total Amount: ${total}");

            // Step 4
            Console.WriteLine("\n--- Apply Discount ---");
            double finalAmount = ApplyDiscount(total);
            Console.WriteLine($"Final Payable Amount: ${finalAmount}");
        }
    }












    }

    

