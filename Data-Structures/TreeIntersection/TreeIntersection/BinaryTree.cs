using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class BinaryTree
    {
        public Node<string> Root { get; set; }

        // Constructor to assign the tree's Root value
        public BinaryTree(string value)
        {
            Root = new Node<string>(value);
        }

        public BinaryTree()
        {

        }
    }
}
