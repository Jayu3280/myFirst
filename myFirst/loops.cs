using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class loops
    {
        static void Main(string[] args)
        {
            ////For Loop
            //Console.WriteLine("--------For Loop---------");

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Number" + i);
            //}

            //Sum of first 10 natural number (1 to 10);
            //Console.WriteLine("--------Sum of First 10 Natural Number (1 to 10)---------");

            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine("Total Sum : " + sum);

            // Even number upto 20
            //Console.WriteLine("--------Even Number upto 20---------");

            //for (int i = 2; i <= 20; i+=2)
            //{
            //    Console.WriteLine(" " + i);
            //}

            //Display Multiplication table
            //Console.WriteLine("Enter Number For Multiplication table");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{num} x {i} = {num * i}");
            //}


            //Nested for loop

            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.Write($"{i * j} \t");

            //    }
            //    Console.WriteLine();
            //}

            //While loop

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 2;
            //while (i <= 20)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}

            //Console.WriteLine("Enter Number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int i = 1, sum = 0;
            //while (i < number)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("sum" + sum);

            //Console.WriteLine("Enter Number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //int rev = 0;

            //while (num> 0)
            //{
            //    int digit = num % 10;
            //    rev = ( rev * 10) + digit;
            //    num = num / 10;
            //}
            //Console.WriteLine(" Reverse Number is = " + rev);

            //Do while

            //int i = 1; 

            //do
            //{
            //    Console.WriteLine(i);
            //    i++; 
            //}
            //while (i <= 5); 

            //do
            //{
            //    Console.WriteLine("Enter 1st number");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Entert 2nd number");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int add = num1 + num2;
            //    Console.WriteLine("Addition Result is " + add);

            //    Console.WriteLine("Do you want to Really Continue - (yes/no");
            //    confirm = Console.ReadLine();
            //} while (confirm == "yes");

            //console.writeLine("Out of Loop");

            int choice;
            do
            {
                Console.WriteLine("---------- Menu Command ----------");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Your Choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter 1st number: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter 2nd number: ");
                    int num2 = int.Parse(Console.ReadLine());

                    int add = num1 + num2;
                    Console.WriteLine("Addition Result is: " + add);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter 1st number: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter 2nd number: ");
                    int num2 = int.Parse(Console.ReadLine());

                    int sub = num1 - num2;
                    Console.WriteLine("Subtraction Result is: " + sub);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Exiting program...");
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                }

                Console.WriteLine(); 

            } while (choice != 3);
        }
    }
}








   