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

        /// <summary>
        /// Check if stack count is zero. If yes, throw a new InvalidOperationException and send a message that the stack is empty. If the stack has value, get the top node's value, assign the top node to be top node.Next, then deduct stack count by 1. Return the top node value that is popped.
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            else
            {
                int popped = this.top.Value;
                this.top = this.top.Next;
                this.count--;
                return popped;
            }
        }

        /// <summary>
        /// Check if stack count is zero. If yes, throw a new InvalidOperationException and send a message that the stack is empty. If the stack has value, get the top node's value then return it. 
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            return this.top.Value;
        }
    
    /// <summary>
    /// Print out all the node values on the stack. Set the current node to be stack top node. While node.Next is not null, keep printing out the node value and go to be next node on the stack until it reaches to the end of the nodes.
    /// </summary>
    /// <returns></returns>
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
