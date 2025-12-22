using System;

namespace myFirst
{
    class NewClass
    {
        public string str;
        public int num;

        public static NewClass operator +(NewClass c1, NewClass c2)
        {
            NewClass obj3 = new NewClass();
            obj3.str = c1.str + c2.str;
            obj3.num = c1.num + c2.num;
            return obj3;
        }
    }

    internal class operator_overloding
    {
        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass();
            NewClass obj2 = new NewClass();
            

            obj1.str = "Shree Samrath ";
            obj1.num = 10;

            obj2.str = "Traders";
            obj2.num = 20;

            // Correct: obj3 only declared once
            NewClass obj3 = obj1 + obj2;

            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);

            Console.ReadLine();
        }
    }
}
