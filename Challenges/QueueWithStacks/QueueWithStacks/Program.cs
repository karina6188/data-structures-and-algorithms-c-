using System;
using System.Collections;

namespace QueueWithStacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            PseudoQuene queue = new PseudoQuene();

            Console.WriteLine("Result of method enqueue(10): ");
            Console.WriteLine("Stack values ");
            queue.enqueue(10);
            Console.WriteLine("\n");
            Console.WriteLine("Result of method dequeue(): ");
            queue.dequeue();
        }
    }
}
