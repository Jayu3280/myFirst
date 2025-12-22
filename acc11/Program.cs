using System;

namespace acc11
{
    public class class1
    {
        // This method prints a message
        public void show1()
        {
            Console.WriteLine("Accessing Public Method");
        }

        // This method was commented out intentionally
        //public void show2()
        //{
        //    class1 obj = new class1();
        //    obj.show1();
        //}
    }

    public class Program1
    {
        static void Main(string[] args)
        {
            // Creating object of class1
            class1 obj = new class1();
            
            // Calling show1 method of class1
            obj.show1();

            Console.ReadLine(); // Wait for user input
        }
    }
}
