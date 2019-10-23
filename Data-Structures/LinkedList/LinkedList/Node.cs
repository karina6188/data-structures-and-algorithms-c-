using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node : LinkedList
    {
        public int Data { get; set; }

        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
