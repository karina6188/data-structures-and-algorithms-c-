using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stackOne = new Stack();
            stackOne.Push(1);
            stackOne.Push(2);
            stackOne.Push(3);
            stackOne.Push(4);
            stackOne.Push(5);
            stackOne.Push(6);
            stackOne.Push(7);
            Console.WriteLine("Push new values to the stack: ");
            stackOne.PrintStack();

            stackOne.Pop();
            stackOne.Pop();
            Console.WriteLine("");
            Console.WriteLine("Pop values from the stack: ");
            stackOne.PrintStack();

            Console.WriteLine("");
            Console.WriteLine("Peek the top value from the stack: ");
            Console.WriteLine(stackOne.Pop());

            Console.WriteLine("");
            Console.WriteLine("Is it true that the stack is empty?");
            Console.WriteLine(stackOne.isEmpty());


            Queue queueOne = new Queue();
            queueOne.Enqueue(1);
            queueOne.Enqueue(2);
            queueOne.Enqueue(3);
            queueOne.Enqueue(4);
            queueOne.Enqueue(5);
            Console.WriteLine("");
            Console.WriteLine("Enqueue new values to the queue: ");
            queueOne.PrintQueue();
        }
    }
}
