using System;
using System.Collections.Generic;

namespace myFirst
{
    internal class generic_stack_ex1
    {
        // Make PrintNumber accept any IEnumerable<T>
        static void PrintNumber<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // ------------------ STACK ------------------
            Console.WriteLine("----- STACK -----");
            Stack<int> numbers = new Stack<int>();
            numbers.Push(201);
            numbers.Push(202);
            numbers.Push(203);
            numbers.Push(204);
            numbers.Push(205);

            Console.WriteLine("Stack elements (LIFO):");
            PrintNumber(numbers);

            // Pop example
            Console.WriteLine("Pop from stack: " + numbers.Pop());
            Console.WriteLine("Stack after pop:");
            PrintNumber(numbers);

            // Peek example
            Console.WriteLine("Peek top element: " + numbers.Peek());
            Console.WriteLine();

            // ------------------ QUEUE ------------------
            Console.WriteLine("----- QUEUE -----");
            Queue<int> queueNumbers = new Queue<int>();
            queueNumbers.Enqueue(301);
            queueNumbers.Enqueue(302);
            queueNumbers.Enqueue(303);
            queueNumbers.Enqueue(304);
            queueNumbers.Enqueue(305);

            Console.WriteLine("Queue elements (FIFO):");
            PrintNumber(queueNumbers);

            Console.ReadLine();
        }
    }
}

