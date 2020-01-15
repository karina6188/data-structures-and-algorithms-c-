using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public BinaryTree(int value)
        {
            Root = new Node<T>(value);
        }

        public BinaryTree()
        {

        }

        /// <summary>
        /// Take in the root node of the tree and the value that is going to be added to the tree.
        /// Check if the tree has a node. If not, assign the root node to be the new node with the value.
        /// Otherwise, compare the value to the root node's value.
        /// If value is less than the root node's value, go to the node's left child and recursively call the method until it reaches to the leaf node then add the new node to be the leaf node's left child.
        /// If value is greater than the root node's value, go to the node's right child and recursively call the method until it reaches to the leaf node then add the new node to be the leaf node's right child.
        /// If value is equal to a node's value just return the node without adding a new node.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node add(Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value);
            }
            else if (value < node.Value)
            {
                node.LeftChild = add(node.LeftChild, value);
            }
            else if (value > node.Value)
            {
                node.RightChild = add(node.RightChild, value);
            }
            else
            {
                return node;
            }
            return node;
        }

        /// <summary>
        /// Create an empty List to store node values on the tree. Create an empty queue and enqueue the root node on to the queue.
        /// While there are nodes on the queue, keep dequeueing the nodes and add the node's value to the List.
        /// As long as the node has children, enqueue the node's children and dequeue the node.
        /// Everytime when a node is dequeued from the queue, add the node's value to the List.
        /// Keep doing this until all the nodes are traversed and no nodes are left on the queue.
        /// Return the List with all the node values.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<int> traverseBinarySearch(Node node)
        {
            List<int> traversal = new List<int>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(node);

            while (breadth.Count > 0)
            {
                try
                {
                    Node front = breadth.Dequeue();
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
                catch (NullReferenceException e)
                {
                    Console.WriteLine("The tree is empty.");
                    Console.WriteLine(e.Message);
                }
            }
            return traversal;
        }

        /// <summary>
        /// Take the tree's root node and the value that is to be searched then use Contains() method to check if the List contains the value.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool contains(Node node, int value)
        {
            List<int> traversal = traverseBinarySearch(node);
            return traversal.Contains(value);
        }
    }
}
