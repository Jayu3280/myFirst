using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myFirst
{
    internal class multithreading_ex3
    {
        static void LongRunningTask()
        {
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("Working......." + 1);
                }
            }
            catch(ThreadAbortException ex)
            {
                Console.Write("Thread was Aborted");
                Thread.ResetAbort();
            }    
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(LongRunningTask);
            t.Start();

            Console.WriteLine("Aboting the thread");
            t.Abort(); // Forcefully stop the thread

            t.Join();  //wait for the thread Exit

            Console.WriteLine(" Main Thread Ends");


            Console.ReadLine();
        }
    }
}
