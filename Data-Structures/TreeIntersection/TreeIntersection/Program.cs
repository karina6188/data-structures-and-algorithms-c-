using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree treeA = new BinaryTree("Tree-A");

            Node nodeA2 = new Node("A");
            Node nodeA3 = new Node("B");
            Node nodeA4 = new Node("C");
            Node nodeA5 = new Node("D");
            Node nodeA6 = new Node("E");
            Node nodeA7 = new Node("F");
            Node nodeA8 = new Node("G");

            treeA.Root.LeftChild = nodeA2;
            treeA.Root.RightChild = nodeA3;
            nodeA2.LeftChild = nodeA4;
            nodeA2.RightChild = nodeA5;
            nodeA3.LeftChild = nodeA6;
            nodeA3.RightChild = nodeA7;
            nodeA4.LeftChild = nodeA8;

            BinaryTree treeB = new BinaryTree("Tree-B");

            Node nodeB2 = new Node("H");
            Node nodeB3 = new Node("D");
            Node nodeB4 = new Node("F");
            Node nodeB5 = new Node("D");
            Node nodeB6 = new Node("B");
            Node nodeB7 = new Node("K");
            Node nodeB8 = new Node("Y");

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
            while (tree1.Root != null)
            {

            }

            List<string> commonValues = new List<string>();

            return commonValues;
        }
    }
}
