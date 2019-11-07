using FizzBuzzTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree(T value)
        {
            Root = new Node<T>(value);
        }

        public Tree()
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
    }
}