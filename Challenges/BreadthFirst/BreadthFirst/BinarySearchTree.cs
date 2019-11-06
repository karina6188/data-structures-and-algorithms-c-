using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class BinarySearchTree<T>
    {
        public Node<T> Root { get; set; }

        public BinarySearchTree(T value)
        {
            Root = new Node<T>(value);
        }

        public BinarySearchTree()
        {

        }

        public List<T> Add()
        {

        }
    }
}
