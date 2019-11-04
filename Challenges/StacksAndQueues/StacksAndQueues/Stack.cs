using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node top;
        public int count;

        /// <summary>
        /// A constructor to initialize a stack with the top to be null and count to be zero.
        /// </summary>
        public Stack()
        {
            this.top = null;
            this.count = 0;
        }

        /// <summary>
        /// Get the value of stack count.
        /// </summary>
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        /// <summary>
        /// Check if stack has anything in it.
        /// If not, add a new node with the value and assign stack top to be the new node.
        /// If yes, add a new node with the value and points to the stack top because this new node will be the top node. Then the top node starts to point the new node.
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            if (this.top == null)
            {
                this.top = new Node(value);
            }
            else
            {
                Node newNode = new Node(value, this.top);
                this.top = newNode;
            }
            this.count++;
        }

        public int PrintStack()
        {
            Node current = this.top;
            int numberOfNodes = 1;
            while (current.Next != null)
            {
                Console.WriteLine("__" + current.Value + "__");
                current = current.Next;
                numberOfNodes++;
            }
            Console.WriteLine("__" + current.Value + "__");
            return numberOfNodes;
        }
    }
}
