using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class constructor_overloding
    {
        public constructor_overloding()
        {
            Console.WriteLine("First Default Constructor");
        }

        public constructor_overloding(int a, int b)
        {
            Console.WriteLine($"2 Parameter Counstrctor Sum : { a + b }");
        }

        public constructor_overloding(int a, int b, int c)
        {
            Console.WriteLine($"3 Parameter Counstrctor Sum : {a + b + c}");
        }
        public constructor_overloding(int a, int b, string c)
        {
            Console.WriteLine($"3 Parameter Counstrctor Sum : {a + b } {c}");
        }
       


        static void Main(string[] args)
        {
            constructor_overloding  c = new constructor_overloding();
            constructor_overloding c1 = new constructor_overloding(20,30);
            constructor_overloding c2 = new constructor_overloding(20, 30, 20);
            constructor_overloding c3 = new constructor_overloding(20, 30, "Jaynat");
            

            Console.ReadLine();
        }
    }
}
