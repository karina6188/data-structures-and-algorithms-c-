using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class Node : LinkedList
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
