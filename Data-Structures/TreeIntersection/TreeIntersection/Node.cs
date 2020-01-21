using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class Node
    {
        // Property - Node's value of a generic type
        public string Value { get; set; }

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }

        // Node class constructor
        public Node(string value)
        {
            Value = value;
        }
    }
}
