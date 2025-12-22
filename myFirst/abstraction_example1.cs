using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class abstraction_example1
    {
        abstract class person101
        {
            public string name;
            public int age;
            public long phoneNumber;

            public abstract void printDetails();  //abstract method
            public void display()
            {
                Console.WriteLine("This is Non Abstract Method");
            }

        }

        class student101 : person101
        {
            public int Rollno;
            public int fees;

            public override void printDetails()
            {
                Console.WriteLine($"Student Name : {name}");
                Console.WriteLine($"Age : {age}");
                Console.WriteLine($"Phone Number : {phoneNumber}");
                Console.WriteLine($"Roll no and Fees : {Rollno} - {fees}");
            }

        }
      


        static void Main(string[] args)
        {
           student101 s1 = new student101();
            s1.name = "Jayant";
            s1.age = 22;
            s1.phoneNumber = 9526897425;
            s1.fees = 250;
            s1.Rollno = 290;
            s1.printDetails();

            Console.ReadLine();
        }
    }
}
