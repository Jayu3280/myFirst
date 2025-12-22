using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class array
    {
        static void Main(string[] args)
        {
            //    int[] numnbers = { 10, 20, 30, 40, 50 };
            //    Console.WriteLine("Array Elements");

            //    for(int i = 0; i <numnbers.Length; i++)
            //    {
            //        Console.WriteLine($"Elements at index {i} = {numnbers[i]}");
            //    }


            //int[] marks = new int[5];
            //Console.WriteLine("Enter marks for 5 subject");

            //for(int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine($"Enter Marks {i + 1} :");
            //    marks[i] = Convert.ToInt32( Console.ReadLine() );

            //}
            //Console.WriteLine("Entered marks");
            //for (int i = 0;i < marks.Length;i++)
            //{
            //    Console.WriteLine($"Subject {i + 1} : {marks[i]}");
            //}


            //string[] names = { "Jayant", "Divyesh", "Nitin", "Ram" };

            //Console.WriteLine("Names in Array");

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //object[] mixed = { 1, "Jayant", 75.13, true };
            //Console.WriteLine("Mixed array") ;
            //for(int i = 0; i < mixed.Length; i++)
            //{
            //    Console.WriteLine(mixed[i]);
            //}


            //int[,] number =
            //{
            //    {1,2,3},
            //    {4,5,6},
            //    {5,6,7},
            //};
            //Console.WriteLine("2D array");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(number[i, j] + "\t");

            //    }
            //    Console.WriteLine();
            //}

            //int[,] marks = new int[2, 3];

            //Console.WriteLine("Enter marks for 2 student (3 subject)");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"Student {i + 1} : ");

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"Enter marks {j + 1}");
            //        marks[i, j] = Convert.ToInt32(Console.ReadLine());

            //    }
            //}
            //Console.WriteLine("Marks Entered:");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"Student : {i + 1} :");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(marks[i, j] + "\t");

            //    }
            //    Console.WriteLine();

            //}

            //int[][] arr = new int[3][];

            //arr[0] = new[] { 12, 24, 56, 89 };
            //arr[1] = new[] { 13, 21, 76, 89, 76, 23 };
            //arr[2] = new[] { 12, 24, 46,  };


            //Console.WriteLine(arr[1][2]);

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.WriteLine(arr[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("Enter number of students:");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            int[][] studentMarks = new int[studentCount][];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Enter number of subjects for student {i + 1}:");
                int subjectCount = Convert.ToInt32(Console.ReadLine());

                studentMarks[i] = new int[subjectCount];

                for (int j = 0; j < subjectCount; j++)
                {
                    Console.WriteLine($"Enter the mark for subject {j + 1}:");
                    studentMarks[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n--- Students' Marks ---");

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j < studentMarks[i].Length; j++)
                {
                    Console.Write(studentMarks[i][j] + "\t ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();




        }
    }
}