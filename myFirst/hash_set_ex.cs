using System;
using System.Collections.Generic;

namespace myFirst
{
    internal class hash_set_ex
    {
        static void Main(string[] args)
        {
            HashSet<string> fruitset = new HashSet<string>();
            fruitset.Add("Apple");
            fruitset.Add("Banana");
            fruitset.Add("Orange");
            fruitset.Add("Mango");

            
            bool added = fruitset.Add("Apple");
            Console.WriteLine("Tried to add 'Apple' again: " + (added ? "Added" : "Already Exists"));

           
            Console.WriteLine("Fruits in the set:");
            foreach (var fruit in fruitset)
            {
                Console.WriteLine(fruit);
            }

            
            Console.WriteLine("Contains 'Banana': " + fruitset.Contains("Banana"));

            
            //HashSet<string> newfruits = new HashSet<string> { "Mango", "Banana", "Papaya" };
            //fruitset.UnionWith(newfruits);

            //Console.WriteLine("-----After Union-----");
            //foreach (var fruit in fruitset)
            //{
            //    Console.WriteLine(fruit);
            //}

            //HashSet<string> seasonfruits = new HashSet<string>()
            //{
            //    "Pineaplle" , "Apple", "Banana" , "Cheery"
            //};
            //fruitset.IntersectWith(seasonfruits);
            //Console.WriteLine("-------After Intersect-------");
            //foreach (var fruit in fruitset)
            //{
            //    Console.WriteLine(fruit);
            //}
            HashSet<string> toRemove = new HashSet<string>()
            {
                "Mango"
            };
            fruitset.ExceptWith(toRemove);
            Console.WriteLine("-------After ExceptWith------");
            foreach (var fruit in fruitset)
            {
                Console.WriteLine(fruit);
            }


            Console.ReadLine();
        }
    }
}
