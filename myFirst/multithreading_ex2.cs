using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myFirst
{
    internal class multithreading_ex2
    {
        static void PrintA()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("A");
            }
        }

        static void PrintB()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("B");
                Console.WriteLine("Thread is going to sleep");
                if (i == 10)
                {
                    Thread.Sleep(8000);
                }
            }
        }

        static void PrintC()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("C");
            }
        }

        static void PrintD()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("D");
            }
        }


        static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintA);
            Thread t2 = new Thread(PrintB);
            Thread t3 = new Thread(PrintC);
            Thread t4 = new Thread(PrintD);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            Console.ReadLine();
        }
    }

}

