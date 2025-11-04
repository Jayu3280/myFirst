using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            // Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine(); // Jayant
            //Console.WriteLine("Enter Your Addreess");
            //string address = Console.ReadLine(); // Neri

            //Console.WriteLine("My name is " + name + " My address is " + address); //Cocatination

            //Console.WriteLine("My name is {0} and My address is {1}", name, address); //placeholder

            //Console.WriteLine($"My name is {name} and My address is {address}"); //string interpolation

            Console.Write("Jayant");
            Console.Write("Patil");

            Console.WriteLine("Enter the first Number");
            int num1 = Convert.ToInt32(Console.ReadLine()); //int.Parse
            Console.WriteLine("Enter the Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine($"Sum is {sum}");

            Console.ReadLine();
        }
    }
}
