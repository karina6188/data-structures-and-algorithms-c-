using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node2 front;
        public Node2 back;
        public int count;

        /// <summary>
        /// A constructor to initialize a queue with the front property set to be null, back property set to be null, and count set to be zero.
        /// </summary>
        public Queue()
        {
            this.front = null;
            this.back = null;
            this.count = 0;
        }

        /// <summary>
        /// Get the value of queue count.
        /// </summary>
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        /// <summary>
        /// Check if the queue is empty. If yes, add a new node with the value to the queue front and assign queue back to be queue front since there is only one node.
        /// If the queue is not empty, create a new node with the value and assign the queue back to be the new node. Then add the queue count by 1.
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(int value)
        {
            if (this.front == null)
            {
                this.front = new Node2(value);
                this.back = this.front;
            }
            else
            {
                Node2 newNode = new Node2(value, this.back);
                this.back = newNode;
            }
            this.count++;
        }

        /// <summary>
        /// Print out all the node values on the queue. Set the current node to be queue fron node. While node.Next is not null, keep printing out the node value and go to be next node on the queue until it reaches to the end of the nodes.
        /// </summary>
        /// <returns></returns>
        public int PrintQueue()
        {
            Node2 current = this.front;
            int numberOfNodes = 1;
            while (current.Next != null)
            {
                Console.Write("|" + current.Value + "|");
                current = current.Next;
                numberOfNodes++;
            }
            Console.WriteLine("|" + current.Value + "|");
            return numberOfNodes;
        }
    }
}
