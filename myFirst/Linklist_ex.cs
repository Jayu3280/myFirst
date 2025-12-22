using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class Linklist_ex
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();

            numbers.AddFirst(10);    //List : 10
            numbers.AddLast(20);    // 10 -> 20
            numbers.AddFirst(5);   // list : 5-> 10 -> 20
            numbers.AddLast(30);   // list : 5-> 10 -> 20 -> 30
           

            Console.WriteLine("Link list Items");
            foreach(int num in  numbers)
            {
                Console.WriteLine(num + " ");
            }

            var position20 = numbers.Find(20);

            if(position20 != null)
            {
                numbers.AddAfter(position20, 25);
            }
            Console.WriteLine("Link list Items");
            foreach(int num in numbers)
            {
                Console.WriteLine(num + " ");
            }

            var position10 = numbers.Find(10);

            if (position10 != null)
            {
                numbers.AddAfter(position10, 15);
            }
            Console.WriteLine("Link list Items");
            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }



            Console.ReadLine();
        }
    }
}
