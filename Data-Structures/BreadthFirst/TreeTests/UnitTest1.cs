using System;
using Xunit;
using Tree;
using System.Collections.Generic;

namespace TreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiateEmptyTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            Assert.Null(binaryTree.Root);
            Assert.Null(binarySearchTree.Root);
        }

        [Fact]
        public void InstantiateATreeWithRoot()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(20);
            BinarySearchTree binarySearchTree = new BinarySearchTree(37);
            Assert.Equal(20, binaryTree.Root.Value);
            Assert.Equal(37, binarySearchTree.Root.Value);
        }

        [Fact]
        public void AddLeftAndRightChild()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(15);
            Node<int> node2 = new Node<int>(27);
            Node<int> node3 = new Node<int>(29);
            binaryTree.Root.LeftChild = node2;
            binaryTree.Root.RightChild = node3;

            BinarySearchTree binarySearchTree = new BinarySearchTree(8);
            Node<int> nodeA = new Node<int>(2);
            Node<int> nodeB = new Node<int>(12);

            binarySearchTree.Root.LeftChild = nodeA;
            binarySearchTree.Root.RightChild = nodeB;

            Assert.Equal(27, binaryTree.Root.LeftChild.Value);
            Assert.Equal(29, binaryTree.Root.RightChild.Value);
            Assert.Equal(2, binarySearchTree.Root.LeftChild.Value);
            Assert.Equal(12, binarySearchTree.Root.RightChild.Value);
        }

        [Fact]
        public void ReturnInPreOrder()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(54);

            Node<int> node2 = new Node<int>(28);
            Node<int> node3 = new Node<int>(17);
            Node<int> node4 = new Node<int>(21);
            Node<int> node5 = new Node<int>(9);
            Node<int> node6 = new Node<int>(13);
            Node<int> node7 = new Node<int>(2);

            binaryTree.Root.LeftChild = node2;
            binaryTree.Root.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;

            List<int> preOrder = binaryTree.PreOrder(binaryTree.Root);
            List<int> testPreOrder = new List<int> { 54, 28, 21, 9, 17, 13, 2 };
            Assert.Equal(testPreOrder, preOrder);
        }

        [Fact]
        public void ReturnInInOrder()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(54);

            Node<int> node2 = new Node<int>(28);
            Node<int> node3 = new Node<int>(17);
            Node<int> node4 = new Node<int>(21);
            Node<int> node5 = new Node<int>(9);
            Node<int> node6 = new Node<int>(13);
            Node<int> node7 = new Node<int>(2);

            binaryTree.Root.LeftChild = node2;
            binaryTree.Root.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;

            List<int> inOrder = binaryTree.InOrder(binaryTree.Root);
            List<int> testInOrder = new List<int> { 21, 28, 9, 54, 13, 17, 2 };
            Assert.Equal(testInOrder, inOrder);
        }

        [Fact]
        public void ReturnInPostOrder()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(54);

            Node<int> node2 = new Node<int>(28);
            Node<int> node3 = new Node<int>(17);
            Node<int> node4 = new Node<int>(21);
            Node<int> node5 = new Node<int>(9);
            Node<int> node6 = new Node<int>(13);
            Node<int> node7 = new Node<int>(2);

            binaryTree.Root.LeftChild = node2;
            binaryTree.Root.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;

            List<int> PostOrder = binaryTree.PostOrder(binaryTree.Root);
            List<int> testPostOrder = new List<int> { 21, 9, 28, 13, 2, 17, 54 };
            Assert.Equal(testPostOrder, PostOrder);
        }
    }
}
