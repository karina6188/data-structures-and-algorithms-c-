using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class BinarySearchTree
    {
        public Node<int> Root { get; set; }

        public BinarySearchTree(int value)
        {
            Root = new Node<int>(value);
        }

        public BinarySearchTree()
        {

        }

        public Node<int> add(Node<int> node, int value)
        {
            if (node == null)
            {
                node = new Node<int>(value);
            }
            else if (value < node.Value)
            {
                node.LeftChild = add(node.LeftChild, value);
            }
            else
            {
                node.RightChild = add(node.RightChild, value);
            }
            return node;
        }

        List<int> traversal = new List<int>();
        //traversal.Add(node.Value);
        public List<int> traverseBinarySearch(Node<int> node)
        {
            if (node != null)
            {
                if (node.LeftChild != null)
                {
                    traversal.Add(node.LeftChild.Value);
                }
                if (node.RightChild != null)
                {
                    traversal.Add(node.RightChild.Value);
                }
                traverseBinarySearch(node.LeftChild);
                traverseBinarySearch(node.RightChild);
            }
            return traversal;
        }
    }
}
