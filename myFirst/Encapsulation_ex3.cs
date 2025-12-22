using System;

namespace myFirst
{
    class HotelBooking
    {
        private string guestName;
        private string roomNumber;
        private double numberOfDays;
        private double roomRent;
        private double totalBill;

        
        public void BookingDetail()
        {
            Console.WriteLine("Enter Guest Name:");
            guestName = Console.ReadLine();

            Console.WriteLine("Enter Room Number:");
            roomNumber = Console.ReadLine();

            Console.WriteLine("Enter Number of Days:");
            numberOfDays = Convert.ToDouble(Console.ReadLine());
            if (numberOfDays <= 0)
            {
                Console.WriteLine("Invalid Days! Setting days to 1 by default.");
                numberOfDays = 1;
            }

            Console.WriteLine("Enter Room Rent Per Day:");
            roomRent = Convert.ToDouble(Console.ReadLine());
            if (roomRent <= 0)
            {
                Console.WriteLine("Invalid Rent! Setting default rent to 1000.");
                roomRent = 1000;
            }
        }

        
        public void CalculateBill()
        {
            totalBill = numberOfDays * roomRent;
        }

        // Method to show booking summary
        public void ShowBookingSummary()
        {
            Console.WriteLine("\n------ Guest Booking ------");
            Console.WriteLine("Guest Name     : " + guestName);
            Console.WriteLine("Room Number    : " + roomNumber);
            Console.WriteLine("Number of Days : " + numberOfDays);
            Console.WriteLine("Room Rent/Day  : " + roomRent);
            Console.WriteLine("Total Bill     : " + totalBill);
            Console.WriteLine("----------------------------");
        }
    }

    internal class Encapsulation_ex3
    {
        static void Main(string[] args)
        {
            HotelBooking booking = new HotelBooking();

            booking.BookingDetail();    // Correct method name
            booking.CalculateBill();
            booking.ShowBookingSummary();

            Console.ReadLine();
        }
    }
}
