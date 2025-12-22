using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace myFirst
{
    internal class Exception_ex2cs
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int[] arr = { 10, 20, 30 };
            //    Console.WriteLine(arr[5]);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error : Index out of Range" );
            //}

            try
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();  

                
                Console.WriteLine("Your name starts with: " + name[0]);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error : Null Reference Exception occurred (name was null)");
            }

            Console.ReadLine();
        }
    }
}
