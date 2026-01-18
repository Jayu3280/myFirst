using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class Student1003
    {
        public int Id;
        public string Name;

        public Student1003()
        {
            Id = 1;
            Name = "Jayant";

            Console.WriteLine("Default Constructor Called");
        }
        public void Display()
        {
            Console.WriteLine("ID :" + Id);
            Console.WriteLine("Name :" + Name);
        }


    }
    internal class default_constructor
    {
        static void Main(string[] args)
        {
            Student1003 s1 = new Student1003();
            Console.WriteLine("Student Details");
            s1.Display();

            Console.ReadLine();
        }
    }
}
