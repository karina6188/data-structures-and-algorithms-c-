using System;
using System.Collections;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            PseudoQuene queue = new PseudoQuene();

            queue.enqueue(10);
            queue.dequeue();

        }
    }
}
