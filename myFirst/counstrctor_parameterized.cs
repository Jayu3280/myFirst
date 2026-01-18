using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class counstrctor_parameterized
    {
        class Emp
        {
            public int empId;
            public string empName;
            public double salary;

            public Emp( int empId, string empName, double salary)
            {
                this.empId = empId;
                this.empName = empName;
                this.salary = salary;

                Console.WriteLine("Parameterized Constructor Called");
            }
            public void Display()
            {
                Console.WriteLine("Employee Id  " + empId);
                Console.WriteLine("Employee Name : " + empName);    
                Console.WriteLine("Employee Salary : " + salary);   

            }
        }
        static void Main(string[] args)
        {
            Emp e1 = new Emp(101, "Jayant", 25600);
            Emp e2 = new Emp(102, "Gajanan", 23560);
            Emp e3 = new Emp(103, "Divyesh", 35000);

            Console.WriteLine("Empolyee Details");
            e1.Display();
            e2.Display();
            e3.Display();



        }
    }
}
