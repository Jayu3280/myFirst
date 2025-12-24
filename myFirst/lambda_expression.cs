using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class lambda_expression
    {
        class students
        {
            public string name;
            public int marks;
            public int age;

        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Square(int x)
        {
            return x * x;
        }

        static void msg()
        {
            Console.WriteLine("Hello Jayant");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(11, 10)); ----------> Simple Expression
            Func<int,int,int> add = (a, b) => a + b;  //  ----------> lambda_expression
            Console.WriteLine(Add(11, 10));

            Console.WriteLine("-----------");

            //Console.WriteLine(Square(4));
            Func<int,int> square = x => x * x;
            Console.WriteLine(Square(5));

            Console.WriteLine("-----------");

            //msg();
            Action msg = () => Console.WriteLine("Hello Ashwini");
            msg();

            Console.WriteLine("-----------");

            Func<string,string> upper = s => s.ToUpper();
            Console.WriteLine(upper("jayant"));

            Console.WriteLine("-----------");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, };
            var evenNumbers = numbers.Where(n=>n%2==0);
            foreach(int n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-----------");

            List<int> marks = new List<int>() { 30, 40, 44, 50, 65, 23, 21 };
            var passed = marks.Where(m => m >= 30);
            foreach(int n in passed)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-----------");

            List<string> name = new List<string>() { "ashwini", "jayant", "patil" }; //----Upper case
            var upperNames = name.Select(n => n.ToUpper());
            foreach(string n in upperNames)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-----------");

            List<int> numbers1 = new List<int>() { 40, 60, 98, 78, 65, 23, 21 };
            var sorted = numbers1.OrderBy(n => n);
            foreach(int n in sorted)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-----------");

            List<students> students = new List<students>()
            {
                new students { name = "Ashiwini", marks = 15, age = 22 },
                new students { name = "Jayant", marks = 20, age = 20},
                new students { name = "Gajanan", marks = 50, age = 35 },
                new students { name = "Patil", marks = 60, age = 30 },
                new students { name = "Sakshi", marks = 40, age = 40 },

            };
            var passStudents = students.Where(s => s.marks >= 35);
            foreach(var s in passStudents)
            {
                Console.WriteLine(s.name);

            }
            Console.WriteLine("-----------");
            var ageStudents = students.Where(s => s.age >= 30);
            foreach(var s in ageStudents)
            {
                Console.WriteLine(s.name);
            }

            Console.WriteLine("-----------");

            List<int> num = new List<int>() { 10, 23, 36, 65, 42, 23, 11, 43, 26 };

            var groups = num.GroupBy(n => n % 2 == 0);

            foreach(var g in groups)
            {
                Console.WriteLine(g.Key ? "Even Numbers" : "Odd Numbers");
                foreach(var n in g)
                {
                    Console.WriteLine($"{n}");
                }
            }

            Console.WriteLine("-----------");

            List<int> num1 = new List<int>() { 10, 23, 36, 65, 42, 23, 11, 43, 26 };
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());

            Console.WriteLine("-----------");


            foreach (var k in num.Take(3))
            {
                Console.WriteLine(k);
            }

            Console.ReadLine();

        }

        
    }
}
