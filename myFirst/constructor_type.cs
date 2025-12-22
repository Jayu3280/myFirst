using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class constructor_type
    {
        string Name;
        int EmpId;
        int Age;
        int Salary;
        public constructor_type() //default constructor
        {
            Console.WriteLine("Jayant");
        }
        public constructor_type(string name, int emp_id, int age, int salary) 
        {
            Name = name;
            EmpId = emp_id;
            Age = age;
            Salary = salary;
        }
        public string getName()
        { 
            return Name; 
        }

        public int getEmpId()
        {
            return EmpId;
        }

        public int getAge()
        {
            return Age;
        }
        public int getSalary()
        {
            return Salary;
        }

        public string GetDetails()
        {
            return $"Name : {Name}, Emp id :{EmpId},Age : {Age}, Salary : {Salary}";
        }

        public string DisplayDetails()
        {
            return $"Name : {Name}, Emp id :{EmpId},Age : {Age}, Salary : {Salary}";
        }




        static void Main(string[] args)
        {
            //constructor_type s1 = new constructor_type();
            constructor_type s2 = new constructor_type("Jayant",01,58,35000);
            constructor_type s3 = new constructor_type("Ashwini", 02, 26, 40000);
            //Console.WriteLine($"Name : {s2.getName()}");
            //Console.WriteLine($"Emp Id : {s2.getEmpId()}");
            //Console.WriteLine($"Age : {s2.getAge()}");
            //Console.WriteLine($"Salary : {s2.getSalary()}");
            //Console.WriteLine($"Salary : {s2.GetDetails()}");
            //Console.WriteLine($"Salary : {s3.GetDetails()}");
            //s2.DisplayDetails();

            Console.ReadLine();
        }
    }
}
