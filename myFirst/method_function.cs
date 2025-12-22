using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class method_function
    {
        public void show() //non-static / instant method /  non parameter
        {
            Console.WriteLine("Welcome");
        }
        public static void show1() //non-static / instant method /  non parameter
        {
            Console.WriteLine("Hello I am Jayant");
        }
        static void Main(string[] args)
        {
            method_function mf = new method_function();
            mf.show();
            method_function.show1();

            Console.ReadLine();
        }
    }
}
