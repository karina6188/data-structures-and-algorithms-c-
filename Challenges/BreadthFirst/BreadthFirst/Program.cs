using System;
using System.Collections.Generic;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //TraverseBinaryTree();
            TraverseBinarySearchTree();
        }

        static void TraverseBinaryTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(54);

            Node<int> node2 = new Node<int>(28);
            Node<int> node3 = new Node<int>(17);
            Node<int> node4 = new Node<int>(21);
            Node<int> node5 = new Node<int>(9);
            Node<int> node6 = new Node<int>(13);
            Node<int> node7 = new Node<int>(2);
            Node<int> node8 = new Node<int>(49);
            Node<int> node9 = new Node<int>(35);
            Node<int> node10 = new Node<int>(43);

            binaryTree.Root.LeftChild = node2;
            binaryTree.Root.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;
            node4.LeftChild = node8;
            node4.RightChild = node9;
            node5.LeftChild = node10;

            Console.WriteLine("PreOrder:");
            List<int> preOrder = binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine(string.Join(',', preOrder));
            Console.WriteLine();

            Console.WriteLine("InOrder:");
            List<int> inOrder = binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine(string.Join(',', inOrder));
            Console.WriteLine();

            Console.WriteLine("PostOrder:");
            List<int> postOrder = binaryTree.PostOrder(binaryTree.Root);
            Console.WriteLine(string.Join(',', postOrder));
            Console.WriteLine();
        }

        static void TraverseBinarySearchTree()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree(60);

            Node<int> node2 = new Node<int>(25);
            Node<int> node3 = new Node<int>(90);
            Node<int> node4 = new Node<int>(10);
            Node<int> node5 = new Node<int>(70);
            Node<int> node6 = new Node<int>(120);


            binarySearchTree.Root.LeftChild = node2;
            binarySearchTree.Root.RightChild = node3;
            node2.LeftChild = node4;
            node3.LeftChild = node5;
            node3.RightChild = node6;

            Console.WriteLine("Breadth First Binary Search:");
            List<int> breadth = binarySearchTree.traverseBinarySearch(binarySearchTree.Root);
            string rootValue = binarySearchTree.Root.Value.ToString();
            string breadthTraverse = string.Join(',', breadth);
            Console.WriteLine($"{rootValue},{breadthTraverse}");
            Console.WriteLine();
        }
    }
}
