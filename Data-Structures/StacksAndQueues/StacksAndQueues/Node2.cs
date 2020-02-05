using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Node2
    {
        public int Value { get; set; }
        public Node2 Next { get; set; }

        /// <summary>
        /// This constructor initiates a node with a given value and a link that points to null.
        /// </summary>
        /// <param name="value"></param>
        public Node2(int value)
        {
            this.Value = value;
            this.Next = null;
        }

        /// <summary>
        /// This constructor initiates a node with a given value and a link that points to a different value that is not null.
        /// </summary>
        /// <param name="value"></param>
        public Node2(int value, Node2 previous)
        {
            this.Value = value;
            this.Next = null;
            previous.Next = this;
        }
    }
}
