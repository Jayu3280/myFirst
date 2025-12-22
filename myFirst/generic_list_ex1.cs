using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class generic_list_ex1
    {

        static void PrintList(List<string> citylist)
        {
            Console.WriteLine("Current List");
            foreach (string item in citylist)
            {
                Console.WriteLine(item);
            }
        }
        

        static void Main(string[] args)
        {
            List<string> citylist = new List<string>();
            citylist.Add("Jalgaon");
            citylist.Add("Pune");
            citylist.Add("Nashik");
            citylist.Add("Nagpur");

            PrintList(citylist);

            Console.WriteLine("-----Add Range------");
            citylist.AddRange(new List<string> { "Goa", "Nagar", "Mumbai", "Kolkata"});
            PrintList(citylist);

            Console.WriteLine("----Insert at Index-------");
            citylist.Insert(1, "Jamner");
            PrintList(citylist);

            Console.WriteLine("-----Insert Add Range Index------");
            citylist.InsertRange(2,new List<string> { "Satara", "Pandharpur", "Tuljapur", "Kolapur" });
            PrintList(citylist);


            Console.WriteLine("-----Remove City----");
            citylist.Remove("Goa");
            PrintList(citylist);

            Console.WriteLine("-----Remove At Index----");
            citylist.RemoveAt(2);
            PrintList(citylist);

            Console.WriteLine("-----Remove Range Index to Index----");
            citylist.RemoveRange(2,3); //Remove For 2 - to next 4 item
            PrintList(citylist);

            Console.WriteLine("-----Insert Add Range Index------");
            citylist.InsertRange(2, new List<string> { "Satara", "Pandharpur", "Tuljapur", "Kolapur" });
            PrintList(citylist);

            Console.WriteLine("-----Remove All----");
            citylist.RemoveAll(c => c.StartsWith("N")); //Remove with start N
            PrintList(citylist);

            Console.WriteLine("------Contains-----");
            Console.WriteLine("Contains Jamner?" + citylist.Contains("Jamner"));
            PrintList(citylist);

            Console.WriteLine("------Index-----");
            Console.WriteLine("Contains Jamner?" + citylist.IndexOf("Jamner"));
            PrintList(citylist);

            Console.WriteLine("----Sort--------");
            citylist.Sort();
            PrintList(citylist);

            Console.WriteLine("----Reverse-----");
            citylist.Reverse();
            PrintList(citylist);

            Console.WriteLine("---Count-----");
            Console.WriteLine("Count: " + citylist.Count);
            PrintList(citylist);

            Console.WriteLine("-----Clear-----");
            citylist.Clear();
            PrintList(citylist);








            Console.ReadLine();
        }
    }
}
