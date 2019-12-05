using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public BinaryTree(T value)
        {
            Root = new Node<T>(value);
        }

        public BinaryTree()
        {

        }

        /// <summary>
        /// Create a List to store values from nodes. Call PreOrder method to recursively traverse to nodes and add the values. Then check if the node has a left child and get the value. Keep doing this until there is no left child then go back to the previous node to check the right child and get the values.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<T> PreOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();
            PreOrder(node, traversal);
            return traversal;
        }

        public void PreOrder(Node<T> node, List<T> traversal)
        {
            try
            {
                traversal.Add(node.Value);

                if (node.LeftChild != null)
                {
                    PreOrder(node.LeftChild, traversal);
                }
                if (node.RightChild != null)
                {
                    PreOrder(node.RightChild, traversal);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("The tree is empty.");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Create a List to store values from nodes. Call InOrder method to recursively traverse to nodes and check if the node has a left child and get the value. Keep doing this until there is no left child then go back to the previous node and add the node's value. Then go check the node's  right child and get the values.
        /// </summary>
        /// <returns></returns>
        public List<T> InOrder(Node<T> node)
        {
            try
            {
                List<T> traversal = new List<T>();
                InOrder(node, traversal);
                return traversal;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("The tree is empty.");
                Console.WriteLine(e.Message);
                List<T> empty = new List<T>();
                return empty;
            }
        }

        public void InOrder(Node<T> node, List<T> traversal)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild, traversal);
            }

            traversal.Add(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild, traversal);
            }
        }

        /// <summary>
        /// Create a List to store values from nodes. Call PostOrder method to recursively traverse to nodes and check if the node has a left child and get the value. Keep doing this until there is no left child then go back to the previous node to check the node's right child and get the values. Then go back to the previous node and add the node's value.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<T> PostOrder(Node<T> node)
        {
            try
            {
                List<T> traversal = new List<T>();
                PostOrder(node, traversal);
                return traversal;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("The tree is empty.");
                Console.WriteLine(e.Message);
                List<T> empty = new List<T>();
                return empty;
            }
        }

        public void PostOrder(Node<T> node, List<T> traversal)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild, traversal);
            }
            if (node.RightChild != null)
            {
                PostOrder(node.RightChild, traversal);
            }

            traversal.Add(node.Value);
        }
    }
}
