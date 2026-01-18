using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
      class Login
        {
            public virtual void LoginUser()
            {
                Console.WriteLine("Logging in");
            }
        }

       
        class AdminLogin : Login
        {
            public override void LoginUser()
            {
                Console.WriteLine("\n--- Admin Login ---");
                Console.WriteLine("User Login");
                Console.WriteLine("Access - Full Controls");
            }
        }

        class UserLogin : Login
        {
            public override void LoginUser()
            {
                Console.WriteLine("\n--- User Login ---");
                Console.WriteLine("User Login");
                Console.WriteLine("Access - Minimum Controls");
            }
        }

        class GuestLogin : Login
        {
            public override void LoginUser()
            {
                Console.WriteLine("\n--- Guest Login ---");
                Console.WriteLine("Guest Login");
                Console.WriteLine("Access - Only Profile");
            }
        }

        internal class method_overriding_ex2cs
        {
            static void Main(string[] args)
            {
                Login login;

                Console.WriteLine("Choose Login Option:");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Guest");

                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        login = new AdminLogin();
                        login.LoginUser();
                        break;

                    case 2:
                        login = new UserLogin();
                        login.LoginUser();
                        break;

                    case 3:
                        login = new GuestLogin();
                        login.LoginUser();
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.ReadLine();
            }
        }
    }


