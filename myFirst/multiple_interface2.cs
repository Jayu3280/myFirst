using System;

namespace myFirst
{
    public interface IPhone
    {
        void MakeCall(string number, int duration);
        void SendSMS(string number, string message);
    }

    public interface ICamera
    {
        void TakePhoto(string mode, int resolution);
        void RecordVideo(string format, int duration);
    }

    public class Child1 : IPhone, ICamera
    {
        public void MakeCall(string number, int duration)
        {
            Console.WriteLine($"Calling {number} for {duration} minutes...");
        }

        public void SendSMS(string number, string message)
        {
            Console.WriteLine($"Sending SMS to {number}: {message}");
        }

        public void TakePhoto(string mode, int resolution)
        {
            Console.WriteLine($"Taking photo in {mode} mode with 1020 Pixel");
        }

        public void RecordVideo(string format, int duration)
        {
            Console.WriteLine($"Recording {format} video for {duration} minutes...");
        }
    }

    internal class multiple_interface2
    {
        static void Main(string[] args)
        {
            Child1 c = new Child1();

            c.MakeCall("9876543210", 5);
            c.SendSMS("9876543210", "Hello Jayant!");
            c.TakePhoto("Portrait", 12);
            c.RecordVideo("1080p", 20);

            Console.ReadLine();
        }
    }
}
