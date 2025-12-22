using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Globalization;

namespace myFirst
{
    internal class file1
    {
        static void Main(string[] args)
        {
            //string path = @"C:\file\f1.docx";     //verbatim literal
            //if(File.Exists(path))
            //{
            //    Console.WriteLine("Yes there is File Found");
            //}
            //else
            //{
            //   Console.WriteLine("File Not Found");

            //}

            //string path = @"C:\file\f1.docx";
            //if(File.Exists(path))
            //{
            //    Console.WriteLine("File Found");
            //    string data = File.ReadAllText(path);
            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine("File Not Found");
            //}

            //--------------Copy text file-------------
            //string path1 = @"C:\file\f1.docx";   // Source file
            //string path2 = @"C:\file\jayant\f2.docx";   // Destination file

            //if (File.Exists(path1))
            //{
            //    Console.WriteLine("File Found");
            //    File.Copy(path1, path2 ,true);
            //    Console.WriteLine("File Copied Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("File Not Found");
            //}
            //-----------Create , Read, Move , Directory class-------------

            //string path = @"C:\folder2";

            //DirectoryInfo dir = new DirectoryInfo(path);
            //dir .Create();
            //dir.CreateSubdirectory("another_folder");

            //Move-----
            //string path1 = @"C:\folder2";
            //string path2 = @"C:\folder3";

            //DirectoryInfo dir = new DirectoryInfo(path1);
            //dir.MoveTo(path2 );


            //Console.WriteLine("Direcyory Moved");

            //string path1 = @"C:\new";
            //DirectoryInfo directory = new DirectoryInfo(path1);
            //DirectoryInfo[] dirs = directory.GetDirectories();
            //foreach (var item in dirs)
            //{
            //    //Console.WriteLine(item.FullName);
            //    Console.WriteLine(item.GetFiles().Length);
            //}
            string path2 = @"C:\new\n1";
            DirectoryInfo dir2 = new DirectoryInfo(path2);

            Console.WriteLine(dir2.Name);
            Console.WriteLine(dir2.FullName);
            Console.WriteLine(dir2.LastAccessTime);
            Console.WriteLine(dir2.CreationTime);
            Console.WriteLine(dir2.Attributes);
            Console.WriteLine(dir2.Parent);
            Console.WriteLine(dir2.Root);
            Console.WriteLine(dir2.LastWriteTime);
            

            Console.ReadLine();

        }
    }
}

