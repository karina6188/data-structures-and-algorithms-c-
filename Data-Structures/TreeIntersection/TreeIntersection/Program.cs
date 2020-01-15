using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree("START");

            Node<string> node2 = new Node<string>("A");
            Node<string> node3 = new Node<string>("B");
            Node<string> node4 = new Node<string>("C");
            Node<string> node5 = new Node<string>("D");
            Node<string> node6 = new Node<string>("E");
            Node<string> node7 = new Node<string>("F");
            Node<string> node8 = new Node<string>("G");
            Node<string> node9 = new Node<string>("H");
            Node<string> node10 = new Node<string>("I");

            binaryTree.Root.LeftChild = node2;
            binaryTree.Root.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;
            node4.LeftChild = node8;
            node4.RightChild = node9;
            node5.LeftChild = node10;
        }

        static List<string> TreeIntersection(BinaryTree binaryTree1, BinaryTree binaryTree2)
        {
            List<string> commonValues = new List<string>();
            return commonValues;
        }
    }
}
