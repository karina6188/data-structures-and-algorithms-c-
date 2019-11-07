using System;
using System.Collections;
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

        public List<int> traverseBinarySearch(Node<int> node)
        {
            List<int> traversal = new List<int>();
            Queue<Node<int>> breadth = new Queue<Node<int>>();
            breadth.Enqueue(node);

            while (breadth.Count > 0)
            {
                Node<int> front = breadth.Dequeue();
                traversal.Add(front.Value);
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return traversal;
        }
    }
}
