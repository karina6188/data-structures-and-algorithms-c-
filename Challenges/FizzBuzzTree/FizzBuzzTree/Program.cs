using System;
using System.Collections.Generic;
using Tree;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzBinaryTree();
        }

        static void FizzBuzzBinaryTree()
        {
            Tree<object> tree = new Tree<object>(30);

            Node<object> node2 = new Node<object>(28);
            Node<object> node3 = new Node<object>(12);
            Node<object> node4 = new Node<object>(10);
            Node<object> node5 = new Node<object>(7);
            Node<object> node6 = new Node<object>(45);
            Node<object> node7 = new Node<object>(46);
            Node<object> node8 = new Node<object>(13);
            Node<object> node9 = new Node<object>(8);
            Node<object> node10 = new Node<object>(20);

            tree.Root.LeftChild = node2;
            tree.Root.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;
            node5.LeftChild = node8;
            node6.LeftChild = node9;
            node6.RightChild = node10;

            Console.WriteLine("Fizz Buzz Tree:");
            List<object> binaryTree = tree.FizzBuzzTree(tree);
            Console.WriteLine(string.Join(',', binaryTree));
            Console.WriteLine();
        }
    }
}
