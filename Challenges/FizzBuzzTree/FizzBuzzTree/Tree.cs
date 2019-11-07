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
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<object> FizzBuzzTree(Tree<T> tree)
        {
            List<T> traversal = new List<T>();
            int totalNodes = PreOrder(tree.Root, traversal);

            for (int i = 0; i < totalNodes; i++)
            {
                if (int.Parse(traversal[i]) % 15 == 0)
                {

                }
            }

            return traversal;
        }

        public int PreOrder(Node<T> node, List<T> traversal)
        {
            int count = 0;
            try
            {
                traversal.Add(node.Value);
                count ++;

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