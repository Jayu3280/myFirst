using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myFirst
{
    internal class multithreading_ex1
    {
        public static void func1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.Write("Function1" + i);
            }
        }

        public static void func2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.Write("Function2" + i);
                Console.WriteLine("Thread is going to sleep");
                if (i == 10)
                {
                    Thread.Sleep(8000);
                }
            }
        }

        public static void func3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.Write("Function3" + i);
            }
        }
        static void Main(string[] args)
        {
            multithreading_ex1.func1();
            multithreading_ex1.func2();
            multithreading_ex1.func3();

            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();

        }
    }
}
