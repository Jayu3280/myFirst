using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    public delegate void calculation(int a, int b);
    internal class delgate_ex
    {
     

        public static void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition : " + result);
        }

        public static void subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction : " + result);
        }

        public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication: " + result);
        }


        static void Main(string[] args)
        {
            calculation cal = new calculation(delgate_ex.addition);
            //cal.Invoke(20, 40);
            cal = addition;
            cal(40, 60);
            cal = subtraction;
            cal(60, 40);
            cal = multiplication;
            cal(25, 2);


           

            Console.ReadLine();

        }
    }
}
