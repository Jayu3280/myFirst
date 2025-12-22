using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class Employee
    {
        public string name;
        public int age;

        public double GrossSalary;
        double taxDeduction = 0.1;
        double netsalary;

        public Employee(string name, int age, double grossSalary)
        {
            this.name = name;
            this.age = age;
            this.GrossSalary = grossSalary;
        }
        
        private void CalculateSalary()
        {
            if (GrossSalary > 30000)
            {
                netsalary = GrossSalary - (taxDeduction * GrossSalary);
                Console.WriteLine($"Your net Salary {netsalary}");

            }
            else
            {
                Console.WriteLine($"Your net Salary {GrossSalary}");
            }
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine($"Empolyee name : {name}");
            Console.WriteLine($"Empolyee age : {age}");
            this.CalculateSalary();
        }
        internal class abstraction__salary_example
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee("Jayant", 22, 40000);
                e1.ShowEmployeeDetails();
               
                Employee e2 = new Employee("Ashwini", 21, 20000);
                e2.ShowEmployeeDetails();
                

                Employee e3 = new Employee("Gajanan", 45, 50000);
                e3.ShowEmployeeDetails();

                Console.ReadLine();
            }
        }
    }
}
