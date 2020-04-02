using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    public class Node
    {
        public int Data { get; set; }

        public Node Next { get; set; }

        // Constructor
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
