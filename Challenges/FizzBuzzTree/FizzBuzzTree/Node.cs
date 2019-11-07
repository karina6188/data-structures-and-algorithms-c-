﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> LeftChild { get; set; }
        public Node<T> RightChild { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}