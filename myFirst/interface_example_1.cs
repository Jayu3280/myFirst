using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class interface_example_1
    {
        interface IPrinter
        {
            void Print(string document, int pages);

            void Scan(string document, string format);
        }
        class InkjePrinter : IPrinter
        {
            public void Print(string document, int pages)
            {
                Console.WriteLine($"Inkjet Printing {pages} pages of '{document}'");

            }
            public void Scan(string document, string format)
            {
                Console.WriteLine($"Inkjet scanning {document} to {format} format...");
            }
        }


        static void Main(string[] args)
        {
            IPrinter inkjet  = new InkjePrinter();

            Console.WriteLine("------------Inkjet Printer------------");
            inkjet.Print("Report.pdf", 5);
            inkjet.Scan("AddharCard.jpg", "abcd.pdf");

            
          
            Console.ReadLine();
        }
    }
}
