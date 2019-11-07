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
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<object> FizzBuzzTree(Tree<object> tree)
        {
            List<object> traversal = new List<object>();
            int totalNodes = PreOrder(tree.Root, traversal);
            return traversal;
        }

        public int PreOrder(Node<object> node, List<object> traversal)
        {
            int count = 0;
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