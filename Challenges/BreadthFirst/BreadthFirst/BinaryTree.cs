using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class BinaryTree<T>
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
        /// Create a List to store values from nodes. Call PreOrder method to recursively check if a node has a left child and get the value. Keep doing this until there is no left child then go to the right child and get the values.
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
            traversal.Add(node.Value);

            if(node.LeftChild != null)
            {
                PreOrder(node.LeftChild, traversal);
            }
            if(node.RightChild != null)
            {
                PreOrder(node.RightChild, traversal);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<T> InOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();
            InOrder(node, traversal);
            return traversal;
        }

        public void InOrder(Node<T> node, List<T> traversal)
        {
            if(node.LeftChild != null)
            {
                InOrder(node.LeftChild, traversal);
            }

            traversal.Add(node.Value);

            if(node.RightChild != null)
            {
                InOrder(node.RightChild, traversal);
            }
        }

        public List<T> PostOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();
            PostOrder(node, traversal);
            return traversal;
        }

        public void PostOrder(Node<T> node, List<T> traversal)
        {
            if(node.LeftChild != null)
            {
                PostOrder(node.LeftChild, traversal);
            }
            if(node.RightChild != null)
            {
                PostOrder(node.RightChild, traversal);
            }

            traversal.Add(node.Value);
        }
    }
}
