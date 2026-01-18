using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class constructor_copy
    {
        class student1004
        {
            public int id;
            public string name;

            public student1004(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public student1004(student1004 s)
            {
                this.id=s.id;
                this.name=s.name;

                Console.WriteLine("Copy Counstructor Called");
            }
            public void Display()
            {
                Console.WriteLine("Id : " + this.id);   
                Console.WriteLine("Name : " + this.name);
            }
        }
        static void Main(string[] args)
        {
            student1004 s1 = new student1004(1001 , "Jayant");
            Console.WriteLine("Original Object");
            s1.Display();

            //Copy Object

            student1004 s2 = new student1004(s1);
            Console.WriteLine("Copied Object");
            s2.Display();
        }
    }
}
