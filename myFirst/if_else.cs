using System;
using System.Diagnostics;

namespace myFirst
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Your Name:");
            //string name = Console.ReadLine();

            //if (name == "Jayant")
            //{
            //    Console.WriteLine("You are most Welcome");
            //}
            //else
            //{
            //    Console.WriteLine("Who are you?");
            //}

            //Console.WriteLine("Enter percentage:");
            //int percent = Convert.ToInt32(Console.ReadLine());

            //if (percent >= 80)
            //{
            //    Console.WriteLine("Distinction");
            //}
            //else if (percent >= 70)
            //{
            //    Console.WriteLine("First Class");
            //}
            //else if (percent >= 50)
            //{
            //    Console.WriteLine("Second Class");
            //}
            //else if (percent >= 35)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            //Nested if else
            //        Console.WriteLine("Enter username(email id)");
            //string uname = Console.ReadLine();

            //if (uname == "patiljayant3280@gmail.com")
            //{
            //    Console.WriteLine("Enter your password");
            //    string password = Console.ReadLine();

            //    if (password == "1234")
            //    {
            //        Console.WriteLine("Login Successfully");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Wrong Username");
            //}
            //int weeknumber = 2;

            //switch (weeknumber)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thusday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Week Number");
            //        break;
            //}

            Console.WriteLine("Enter your pizza:");
            string pizza = Console.ReadLine();


            switch (pizza)
            {
                case "Corn":
                    Console.WriteLine("Your order is corn pizza");
                    break;

                case "Supreme":
                    Console.WriteLine("Your order is supreme pizza");
                    break;

                case "Vegetable":


                    Console.WriteLine("Select Your Vegetable Choice");
                    string Vegetable = Console.ReadLine();

                    switch (Vegetable)
                    {
                        case "onion":
                            Console.WriteLine("You selected onion pizza");
                            break;

                        case "capcicum":
                            Console.WriteLine("You selected capcicum pizza");
                            break;

                        case "olives":
                            Console.WriteLine("You selected olives pizza");
                            break;


                        default:
                            Console.WriteLine("Invalid Choice");
                            break;


                    }
                    break;

            }



           
                    Console.ReadLine();


        }
    }
}
