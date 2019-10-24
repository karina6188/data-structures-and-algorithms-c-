using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Extended
{
    public class Node : LinkedList_Extended
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
