using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class Node<T>
    {
        // Property - Node's value of a generic type
        public T Value { get; set; }

        public Node<T> LeftChild { get; set; }

        public Node<T> RightChild { get; set; }

        // Node class constructor
        public Node(T value)
        {
            Value = value;
        }
    }
}
