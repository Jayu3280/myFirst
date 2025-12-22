using System;
using System.Collections;

namespace myFirst
{
    internal class non_generic_sortedList
    {
        static void DisplayList(SortedList sl)
        {
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine($"ID : {item.Key}, Name : {item.Value}");
            }
        }

        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add(3, "Jayant");
            sl.Add(5, "Ashwini");
            sl.Add(4, "Gajanan");
            sl.Add(1, "Divyesh");
            Console.WriteLine("=======Sorted List========");
            DisplayList(sl);
            Console.WriteLine("Value of key" + sl[3]);

            Console.WriteLine("Value at index" + sl.GetByIndex(1));

            sl[2] = "Ashwini";
            DisplayList(sl);

            sl.Remove(4);
            DisplayList(sl);


            Console.ReadLine();
        }
    }
}
