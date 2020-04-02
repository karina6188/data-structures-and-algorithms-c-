using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class PseudoQuene
    {
        public Stack stack1 = new Stack();
        public Stack stack2 = new Stack();

        public string enqueue(int value)
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
            string allValues = "";
            foreach (var number in stack1)
            {
                Console.WriteLine(number);
                allValues += number + " ";
            }
            return allValues;
        }

        public string dequeue()
        {
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);

            if(stack1.Count < 1)
            {
                Console.WriteLine("There is no value in the stack.");
            }
            else
            {
                int lastValue = int.Parse(stack1.Peek().ToString());
                stack1.Pop();
                Console.WriteLine(lastValue);
            }
            string remainValues = "";
            foreach (var number in stack1)
            {
                Console.WriteLine(number);
                remainValues += number + " ";
            }
            return remainValues;
        }

        public string enqueue1(int value)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }
            string allValues = "";
            foreach (var number in stack1)
            {
                Console.WriteLine(number);
                allValues += number + " ";
            }
            return allValues;
        }
    }
}
