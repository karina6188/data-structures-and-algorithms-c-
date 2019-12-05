using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class Node<T>
    {
        public object Value { get; set; }
        public Node<object> LeftChild { get; set; }
        public Node<object> RightChild { get; set; }

        public Node(object value)
        {
            Value = value;
        }
    }
}