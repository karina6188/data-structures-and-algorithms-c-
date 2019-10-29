using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class PseudoQuene
    {
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();

        public void enqueue(int value)
        {
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);

            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }

            foreach (var number in stack1)
            {
                Console.WriteLine(number);
            }
        }

        public void dequeue()
        {
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);

            if(stack1.Count < 1)
            {

            }
        }
    }
}
