using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// This constructor initiates a node with a given value and a link that points to null.
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            this.Value = value;
            this.Next = null;
        }

        /// <summary>
        /// This constructor initiates a node with a given value and a link that points to a different value that is not null.
        /// </summary>
        /// <param name="value"></param>
        public Node(int value, Node next)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
