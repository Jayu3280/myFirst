using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class file_stream_mini_project
    {
        public void AddStudentData()
        {
            string path = @"C:\streamwriter\student_data.txt";

            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student Mobile Number:");
            string phoneNo = Console.ReadLine();

            Console.WriteLine("Enter Student Roll No:");
            int rollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Gender:");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter Student Age:");
            int age = int.Parse(Console.ReadLine());

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Name: " + name);
                sw.WriteLine("Mobile No: " + phoneNo);
                sw.WriteLine("Roll No: " + rollNo);
                sw.WriteLine("Gender: " + gender);
                sw.WriteLine("Age: " + age);
                
            }

            Console.WriteLine("Student data saved successfully!");
        }

        public void ViewData()
        {
            string path = @"C:\streamwriter\student_data.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine("\n--- Student Records ---");
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            else
            {
                Console.WriteLine("No data file found.");
            }
        }

        static void Main(string[] args)
        {
            file_stream_mini_project info = new file_stream_mini_project();

            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Student Data");
            Console.Write("Choose option: ");

            string option = Console.ReadLine();

            if (option == "1")
            {
                info.AddStudentData();
            }
            else if (option == "2")
            {
                info.ViewData();
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }

            Console.ReadLine();
        }
    }
}
