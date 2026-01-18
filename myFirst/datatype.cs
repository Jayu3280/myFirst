using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class datatype
    {
        static void Main(string[] args)
        {
            //Value Types
            int age = 25; //Integer Type
            float height = 5.9f; //Floating type - 7 number
            double weight = 0.12d; //15 to 16
            decimal c = 1.898989898989m;//29
            char grade = 'A';
            bool isStudent = true;

            // Refference Type
            string name = " Jayant Patil";
           // object
               // array

            //Nullable Type
            int? nullable = null; //nullable integer (Null value Hold)




            object anything = 11;
            Console.WriteLine("name is " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Decimal value: " + c);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Is Student: " + isStudent);
            Console.WriteLine("Anything object contains: " + anything);



            Console.ReadLine();
        }
    }
}

   
