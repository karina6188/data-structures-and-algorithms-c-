using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree treeA = new BinaryTree("Tree-A");

            Node<string> nodeA2 = new Node<string>("A");
            Node<string> nodeA3 = new Node<string>("B");
            Node<string> nodeA4 = new Node<string>("C");
            Node<string> nodeA5 = new Node<string>("D");
            Node<string> nodeA6 = new Node<string>("E");
            Node<string> nodeA7 = new Node<string>("F");
            Node<string> nodeA8 = new Node<string>("G");

            treeA.Root.LeftChild = nodeA2;
            treeA.Root.RightChild = nodeA3;
            nodeA2.LeftChild = nodeA4;
            nodeA2.RightChild = nodeA5;
            nodeA3.LeftChild = nodeA6;
            nodeA3.RightChild = nodeA7;
            nodeA4.LeftChild = nodeA8;

            BinaryTree treeB = new BinaryTree("Tree-B");

            Node<string> nodeB2 = new Node<string>("H");
            Node<string> nodeB3 = new Node<string>("D");
            Node<string> nodeB4 = new Node<string>("F");
            Node<string> nodeB5 = new Node<string>("D");
            Node<string> nodeB6 = new Node<string>("B");
            Node<string> nodeB7 = new Node<string>("K");
            Node<string> nodeB8 = new Node<string>("Y");

            treeB.Root.LeftChild = nodeB2;
            treeB.Root.RightChild = nodeB3;
            nodeB2.LeftChild = nodeB4;
            nodeB2.RightChild = nodeB5;
            nodeB3.LeftChild = nodeB6;
            nodeB3.RightChild = nodeB7;
            nodeB4.LeftChild = nodeB8;

            TreeIntersection(treeA, treeB);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tree1"></param>
        /// <param name="tree2"></param>
        /// <returns></returns>
        static List<string> TreeIntersection(BinaryTree tree1, BinaryTree tree2)
        {
            // Traverse both trees
            List<string> commonValues = new List<string>();

            return commonValues;
        }
    }
}
