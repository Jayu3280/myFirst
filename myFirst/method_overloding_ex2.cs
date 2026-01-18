using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class method_overloding_ex2
    {
        public void CalculateMarks(int m1)
        {
            Console.WriteLine(" Total Subject 1 ");
            Console.WriteLine("Total Marks" + m1);
            Console.WriteLine("Average = " + m1);
        }

        public void CalculateMarks(int m1 , int m2)
        {
            int total = m1 + m2;
            Console.WriteLine("Total Subject 2 ");
            Console.WriteLine("Total Marks" + total);
            Console.WriteLine("Average = " + (total/2));
        }

        public void CalculateMarks(int m1, int m2 , int m3)
        {
            int total = m1 + m2 + m3;
            Console.WriteLine("Total Subject 3 ");
            Console.WriteLine("Total Marks" + total);
            Console.WriteLine("Average = " + (total / 3));
        }
        static void Main(string[] args)
        {
            method_overloding_ex2 s = new method_overloding_ex2();
            Console.WriteLine("---------Student Marks--------");
            s.CalculateMarks(10);
            Console.WriteLine("---------Student Marks--------");
            s.CalculateMarks(10, 50);
            Console.WriteLine("---------Student Marks--------");
            s.CalculateMarks(20, 40, 60);
        }
    }
}
