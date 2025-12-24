using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class file_stream
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Stream\sample4.txt";

            ////FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            //// FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            //// string message = "Hello Students, Welcome to File Stream";
            //string message = "\n Hello its 2nd line message ewriting";
            ////byte[] data = Encoding.UTF8.GetBytes(message);
            ////byte[] data = new byte[fs.Length];
            //byte[] data = Encoding.UTF8.GetBytes(message);

            //fs.Write(data, 0, data.Length);
            ////fs.Read(data, 0, data.Length);

            ////string content = Encoding.UTF8.GetString(data);

            //fs.Close();
            ////Console.WriteLine("File Content");
            ////Console.WriteLine(content);
            //Console.WriteLine("File Content newly updated");

            //string path = @"C:\Stream\sample4.txt";
            //string path2 = @"C:\Stream\sample_copy.txt";
            //using (FileStream source = new FileStream(path, FileMode.Open, FileAccess.Read))
            //using (FileStream destination = new FileStream(path2, FileMode.Create, FileAccess.Write))
            //{
            //    source.CopyTo(destination);
            //}
            //Console.WriteLine("File Copies Successfully");

            //string path = @"C:\streamwriter\mytxt111.docx";

            //using (StreamWriter sw = new StreamWriter(path,true))
            //{
            //    sw.WriteLine("New added");
            //    sw.WriteLine("Date : " + DateTime.Now);
            //}
            //Console.WriteLine("File Written Successfully");
            //using(StreamReader sr = new StreamReader(path))
            //{
            //    String content = sr.ReadToEnd();
            //    Console.WriteLine("File Content");
            //    Console.WriteLine(content);
            //}

            //string path = @"C:\streamwriter\onetofive.txt";

            //Console.WriteLine("Enter Your Message");
            //string msg = Console.ReadLine();

            //using(StreamWriter sw = new StreamWriter(path,true))
            //{
            //    sw.WriteLine(msg);
            //}
            //Console.WriteLine("User Input saved");

            //using(StreamWriter sw = new StreamWriter(path))
            //{
            //    for(int i = 1;i <=5;i++)
            //    {
            //        sw.WriteLine("Number + i");
            //    }
            //}

            string path = @"C:\streamwriter\studentrecord.txt";

            Console.WriteLine("Enter Student Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Student Mobile Number");
            string mobile = Console.ReadLine();
            Console.WriteLine("Enter Student Address");
            string address = Console.ReadLine();

           string msg = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Student Name: " + name);
                sw.WriteLine("Student Id: " + id);
                sw.WriteLine("Mobile Number: " + mobile);
                sw.WriteLine("Address: " + address);
            }
                Console.WriteLine("Saved Student Record ");
            }

         
        }
}
