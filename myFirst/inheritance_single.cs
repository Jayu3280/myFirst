using System;

namespace myFirst
{
    class person
    {
        public string Name;
        public int Age;

        public void ShowPerson()
        {
            Console.WriteLine($"Name : {Name} , Age : {Age}");
        }
    }

    // Student inherits Person
    class student : person
    {
        public int RollNo;
        public int Marks;

        public student(string name, int age, int rollNo, int marks)
        {
            Name = name;
            Age = age;
            RollNo = rollNo;
            Marks = marks;
        }

        public void ShowStudent()
        {
            Console.WriteLine($"RollNo : {RollNo} , Marks : {Marks}");
        }
    }

    // Teacher inherits Person
    class teacher : person
    {
        public int Salary;

        public void ShowTeacher()
        {
            Console.WriteLine($"Name : {Name} , Age : {Age} , Salary : {Salary}");
        }
    }

    internal class inheritance_single
    {
        static void Main(string[] args)
        {
            student s = new student("Jaynat", 25, 102, 3600);

            s.ShowPerson();
            s.ShowStudent();

            teacher t = new teacher();
            t.Name = "Ashwini";
            t.Age = 21;
            t.Salary = 50000;

            t.ShowTeacher();
        }
    }
}
