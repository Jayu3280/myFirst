using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class student1002 
    {
        public int id;
        public string name;
        public int age;

        public void Display()
        {
            Console.WriteLine("Student Id : " + id);
            Console.WriteLine("Student Nmae : " + name);
            Console.WriteLine("Student Age : " + age);
        }
    }
    internal class Student
    {
        static void Main(string[] args)
        { 
            //Creating Object of student1002 class
            student1002 s1 = new student1002();
            //Assiging Values
            s1.id = 101;
            s1.name = "Jayant";
            s1.age = 22;

            student1002 s2 = new student1002();
            s2.id = 102;
            s2.name = "Ashwini";
            s2.age = 21;

            student1002 s3 = new student1002();
            s3.id = 103;
            s3.name = "Patil";
            s3.age = 20;


            

            //Calling method using object 
            s1.Display();
            Console.WriteLine("=====================");
            s2.Display();
            Console.WriteLine("=====================");
            s3.Display();


        }
    }
}
