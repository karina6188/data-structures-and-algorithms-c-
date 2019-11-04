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

            stackOne.PrintStack();
        }
    }
}
