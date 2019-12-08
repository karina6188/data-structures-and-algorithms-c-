using System;
using System.Collections.Generic;
using System.Text;

namespace LeftJoinHashtables
{
    class Node<T>
    {
        public T Key { get; set; }

        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node(T key, T value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
