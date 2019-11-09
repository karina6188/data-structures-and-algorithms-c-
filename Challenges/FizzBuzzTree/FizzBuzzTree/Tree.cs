using FizzBuzzTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class Tree<T>
    {
        public Node<object> Root { get; set; }

        public Tree(object value)
        {
            Root = new Node<object>(value);
        }

        public Tree()
        {

        }

        /// <summary>
        /// Create an empty List to store the nodes values on the tree. Call PreOrder() method to traverse throught the nodes.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int totalNodes;
        public List<object> FizzBuzzTree(Tree<object> tree)
        {
            List<object> traversal = new List<object>();
            totalNodes = PreOrder(tree.Root, traversal);
            return traversal;
        }

        /// <summary>
        /// Traverse throught the nodes and count how many nodes are on the tree.
        /// When traversing through the node, check if the node's value is divisible by 3, 5, or 15.
        /// If yes, replace the values to be "Fizz", "Buzz", and "FizzBuzz" before saving the value to List.
        /// Keep doing this if the node has children and keep checking, replacing, and saving values to List.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="traversal"></param>
        /// <returns></returns>
        public int count = 0;
        public int PreOrder(Node<object> node, List<object> traversal)
        {
            try
            {
                if (Convert.ToInt32(node.Value) % 15 == 0)
                {
                    node.Value = "FizzBuzz";
                    traversal.Add(node.Value);
                    count++;
                }
                else if (Convert.ToInt32(node.Value) % 3 == 0)
                {
                    node.Value = "Fizz";
                    traversal.Add(node.Value);
                    count++;
                }
                else if (Convert.ToInt32(node.Value) % 5 == 0)
                {
                    node.Value = "Buzz";
                    traversal.Add(node.Value);
                    count++;
                }
                else
                {
                    traversal.Add(node.Value);
                    count++;
                }

                if (node.LeftChild != null)
                {
                    PreOrder(node.LeftChild, traversal);
                }
                if (node.RightChild != null)
                {
                    PreOrder(node.RightChild, traversal);
                }
                return count;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("The tree is empty.");
                Console.WriteLine(e.Message);
                return count;
            }
        }
    }
}