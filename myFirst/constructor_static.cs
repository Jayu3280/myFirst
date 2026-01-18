using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class Company
    {
        public static string companyName;
        public int employeeId;

        static Company()
        {
            companyName = "Tata Motors";
            Console.WriteLine("Static Constructor Called");
        }

        public Company (int employeeId)
        {
            this.employeeId = employeeId;
            Console.WriteLine("Parameterized Counstructor Called");
        }
        public void Display()
        {
            Console.WriteLine("Company Name : " +companyName);
            Console.WriteLine("Emp Id : " + employeeId);    
        }
    }
    internal class constructor_static
    {
        static void Main(string[] args)
        {
            Company c1 = new Company(1001);
            c1.Display();

            Company c2 = new Company(1002);
            c2.Display();

        }
    }
}
