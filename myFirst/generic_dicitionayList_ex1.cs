using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class generic_dicitionayList_ex1
    {
        static void PrintStudentList(Dictionary<int, string> studentList)
        {
            foreach (var student in studentList)
            {
                Console.WriteLine("student Id : " + student.Key + "Name :" + student.Value);
            }
        }

        static void Main(string[] args)
        {
            Dictionary<int, string> student = new Dictionary<int, string>();

            student.Add(101, "Jayant");
            student.Add(102, "Ashwini");
            student.Add(103, "Gajanan");
            student.Add(104, "Nitin");
            PrintStudentList(student);

            Console.WriteLine("-----Containe key------");
            Console.WriteLine("Contains Key 102? " + student.ContainsKey(102));
            Console.WriteLine("Contains Key 200? " + student.ContainsKey(200));
            Console.WriteLine();

            Console.WriteLine("-----Containe Value------");
            Console.WriteLine("Contains Value 'Nitin'? " + student.ContainsValue("Nitin"));
            Console.WriteLine("Contains Value 'Divyesh'? " + student.ContainsValue("Divyesh"));
            Console.WriteLine();

            student[103] = "Ram";
            student.Remove(0);
            PrintStudentList(student);

            foreach (var key in student.Keys)
            {
                Console.WriteLine("Key : " + key);
            }

            Console.ReadLine();
   
        }
    }
}
