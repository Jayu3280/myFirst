using System;

namespace myFirst
{
    internal class OperatorDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number (a):");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number (b):");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=================");
            Console.WriteLine("Arithmetic Operators");
            Console.WriteLine("=================");

            Console.WriteLine($"a + b = {a + b}");   // Addition
            Console.WriteLine($"a - b = {a - b}");   // Subtraction
            Console.WriteLine($"a * b = {a * b}");   // Multiplication
            Console.WriteLine($"a / b = {(b != 0 ? ((double)a / b).ToString("F2") : "undefined (division by zero)")}"); // Division
            Console.WriteLine($"a % b = {(b != 0 ? (a % b).ToString() : "undefined (mod by zero)")}"); // Modulus

            Console.WriteLine("\n=================");
            Console.WriteLine("Relational Operators");
            Console.WriteLine("=================");

            Console.WriteLine($"a == b : {a == b}");  // Equal to
            Console.WriteLine($"a != b : {a != b}");  // Not Equal to
            Console.WriteLine($"a > b  : {a > b}");   // Greater than
            Console.WriteLine($"a < b  : {a < b}");   // Less than
            Console.WriteLine($"a >= b : {a >= b}");  // Greater than or equal to
            Console.WriteLine($"a <= b : {a <= b}");  // Less than or equal to

            Console.WriteLine("=================");
            Console.WriteLine("Logical Operator");
            Console.WriteLine("=================");
            bool x = (a > 0);
            bool y = (b > 0);

            Console.WriteLine($"x && y = {x && y}");
            Console.WriteLine($"x || y = {x ||  y}");
            Console.WriteLine($"!x = {!x}");
            Console.WriteLine("=================");

            Console.WriteLine("=================");
            Console.WriteLine("Assignment Operator");
            Console.WriteLine("=================");

            int c = a;

            c += b;
            Console.WriteLine($" c +=b : {c}");
            c -= b;
            Console.WriteLine($" c -=b : {c}");
            c *=b;
            Console.WriteLine($" c *=b : {c}");

            c /=b;
            Console.WriteLine($" c /=b : {c}");

            c %= b;
            Console.WriteLine($" c %=b : {c}");

            Console.WriteLine("=================");


            Console.WriteLine("=================");
            Console.WriteLine("Unary Operator");
            Console.WriteLine("=================");

            int num = a;
            Console.WriteLine($"num++ = {num++}");
            Console.WriteLine($"++num = {++num}");
            Console.WriteLine($"num-- = {num--}");
            Console.WriteLine($"--num = {--num}");
            Console.WriteLine("=================");

            Console.WriteLine("=================");
            Console.WriteLine("Bitwise Operator");
            Console.WriteLine("=================");
            Console.WriteLine($" a & b = {a & b}");
            Console.WriteLine($" a | b = {a | b}");
            Console.WriteLine($" a ^ b = {a ^ b}");
            Console.WriteLine($" ~a  = {~a}");
            Console.WriteLine($" a << b = {a << 1}");
            Console.WriteLine($" a >> b = {a >> b}");
            Console.WriteLine("=================");

            Console.WriteLine("=================");
            Console.WriteLine("Ternary Operator");
            Console.WriteLine("=================");
            string result = (a > b) ? "a is grater" : " b is grater";
            Console.WriteLine(result);

           
            Console.ReadLine();
        }
    }
}

