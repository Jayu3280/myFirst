using System;
using System.Collections;

namespace myFirst
{
    internal class non_generic_hashtable
    {
        // Corrected: removed semicolon and added printing
        static void DisplayProduct(Hashtable ht)
        {
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"ID: {item.Key}, Value: {item.Value}");
            }
        }

        static void Main(string[] args)
        {
            Hashtable products = new Hashtable();

            products.Add(101, "Laptop");
            products.Add(102, "Mobile");
            products.Add(103, "Tablet");
            Console.WriteLine("Initail Product List");

          
            DisplayProduct(products);

            Console.WriteLine($"\n Total Product : {products.Count}");
            Console.WriteLine($"\n Product with ID 102 - {products[102]}");
            products[102] = "Smart Phone";
            Console.WriteLine("Updated Product with ID 102");
            Console.WriteLine($"\n Product with ID 102 - {products[102]}");

            DisplayProduct(products);

            products[103] = "I phone";
            Console.WriteLine("Updated Product with ID 103");
            Console.WriteLine($"\n Product with ID 103 - {products[103]}");

            DisplayProduct(products);

            if (products.ContainsKey(103))
            {
                Console.WriteLine("Product key Exists");
            }
            if(products.ContainsValue("I phone  "))
            {
                Console.WriteLine("Product name exists");

            }
            else
            {
                Console.WriteLine("Product name does not exists");
            }
            products.Remove(101);
            DisplayProduct(products );

            products.Clear();
            Console.WriteLine($"\n Total Products : {products.Count}");

                Console.ReadLine();
        }
    }
}
