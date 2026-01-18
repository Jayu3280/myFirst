using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Person12
    {
        private string name;
        private int age;
        private double marks;

        public void setName(string name)
        {
            if (string.IsNullOrEmpty(name) == true)
            {
                Console.WriteLine("Name is Required");
            }
            else
            {
                this.name = name;
            }
        }
        public void getName()
        {
            if (string.IsNullOrEmpty(name) != true)
            {
                Console.WriteLine("Your name is :" + this.name);
            }
        }
        public void setAge(int age)
        {
            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("your age is not zero or negative");
            }
        }
        public void getAge()
        {
            if (this.age > 0)
            {
                Console.WriteLine("your age  is." + this.age);
            }
            else
            {
            }
        }

        //-----------------------
        public void setMarks(double marks)
        {
            if (age > 0 && marks < 100)
            {
                this.marks = marks;

            }
            else
            {
                Console.WriteLine("Enter a vaild marks");

            }
        }
        public void getMarks()
        {
            if (this.marks > 0 && marks < 100)
            {
                Console.WriteLine("your marks  is." + this.marks);
            }
            else
            {
            }
        }
    }
    internal class Encapsulation1
    {
        static void Main(string[] args)
        {
            Person12 p = new Person12();
            p.setName("Jayant");
            p.getName();
            p.setAge(22);
            p.getAge();

            //---------------------
            p.setMarks(101);
            p.getMarks();



            Console.ReadLine();
        }
    }
}