using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class sorted_list_ex
    {
        static void Main(string[] args)
        {
            SortedList<int, string> students = new SortedList<int, string>();

            students.Add(103, "Ashwini");
            students.Add(102, "Jayant");
            students.Add(101, "Gajanan");

            Console.WriteLine("Studentlist");
            foreach (var pair in students)
            {
                Console.WriteLine($"Roll No {pair.Key} and Name is {pair.Value}");
            }
           

            Console.ReadLine();
        }
    }
}
