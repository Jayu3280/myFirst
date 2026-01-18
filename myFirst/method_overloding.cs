using System;

namespace myFirst
{
    internal class method_overloding
    {
        // Addition methods
        public void Addition()
        {
            int a = 10;
            int b = 12;
            int c = a + b;
            Console.WriteLine(c);
        }

        public void Addition(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        public void Addition(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine(d);
        }

        public void Addition(int a, double b)
        {
            double c = a + b;
            Console.WriteLine(c);
        }

        public void Addition(double b, int a)
        {
            double c = b + a;
            Console.WriteLine(c);
        }

        // BookRoom methods

        // 1️⃣ Basic room booking
        public void BookRoom(string roomType)
        {
            Console.WriteLine($"Room '{roomType}' booked successfully.");
        }

        // 2️⃣ Room booking with guests
        public void BookRoom(string roomType, int guests)
        {
            Console.WriteLine($"Room '{roomType}' booked for {guests} guests.");
        }

        // 3️⃣ Room booking with guests and extra bed
        public void BookRoom(string roomType, int guests, bool extraBed)
        {
            string bedMessage = extraBed ? "with extra bed" : "without extra bed";
            Console.WriteLine($"Room '{roomType}' booked for {guests} guests {bedMessage}.");
        }

        static void Main(string[] args)
        {
            method_overloding p1 = new method_overloding();

            // Example Addition call
            p1.Addition(63.4, 65);
            p1.Addition(45, 56.25);

            // Room bookings
            p1.BookRoom("1BHK");                        // method 1
            p1.BookRoom("1BHK", 5);                     // method 2
            p1.BookRoom("1BHK", 5, true);              // method 3 (extra bed)


            Console.ReadLine();
        }
    }
}
