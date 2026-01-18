using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class car
    {
        public string brand;
        public string color;
        public int max_speed;


        public void ShowDetail()
        {
            Console.WriteLine("Car Brand : " + brand);
            Console.WriteLine("Car Color : " + color);
            Console.WriteLine("Car Max_speed : " + max_speed);  
        }
    }
    internal class car_ex1
    {
        static void Main(string[] args)
        {
            car c1 = new car();
            c1.brand = "Mahindra Thar";
            c1.color = "Black";
            c1.max_speed = 160;

            car c2 = new car();
            c2.brand = "Tata Punch";
            c2.color = "Red";
            c2.max_speed = 150;


            c1.ShowDetail();
            Console.WriteLine("===============");
            c2.ShowDetail();

        }
    }
}
