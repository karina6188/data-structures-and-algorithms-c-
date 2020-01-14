using FizzBuzzTree;
using System;
using System.Collections.Generic;
using Tree;
using Xunit;

namespace FizzBuzzTreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiateEmptyTree()
        {
            Tree<object> tree = new Tree<object>();
            Assert.Null(tree.Root);
        }

        [Fact]
        public void InstantiateTreeWithInt()
        {
            Tree<object> tree = new Tree<object>(70);
            Assert.Equal(70, tree.Root.Value);
        }

        [Fact]
        public void InstantiateTreeWithString()
        {
            Tree<object> tree = new Tree<object>("fuzzy");
            Assert.Equal("fuzzy", tree.Root.Value);
        }

        [Fact]
        public void AddLeftAndRightChild()
        {
            Tree<object> tree = new Tree<object>(15);
            Node<object> node2 = new Node<object>("snow");
            Node<object> node3 = new Node<object>("ball");
            tree.Root.LeftChild = node2;
            tree.Root.RightChild = node3;

            Assert.Equal("snow", tree.Root.LeftChild.Value);
            Assert.Equal("ball", tree.Root.RightChild.Value);
        }

        [Fact]
        public void ReturnTheTreeWithMixedDataTypes()
        {
            Tree<object> tree = new Tree<object>(0);

            Node<object> node2 = new Node<object>(6);
            Node<object> node3 = new Node<object>(8);
            Node<object> node4 = new Node<object>(5);
            Node<object> node5 = new Node<object>(11);
            Node<object> node6 = new Node<object>(7);
            Node<object> node7 = new Node<object>(15);
            Node<object> node8 = new Node<object>(12);

            tree.Root.LeftChild = node2;
            tree.Root.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;
            node6.LeftChild = node8;

            List<object> theTree = tree.FizzBuzzTree(tree);
            List<object> testTree = new List<object> { "FizzBuzz", "Fizz", "Buzz", 11, 8, 7, "Fizz", "FizzBuzz" };
            Assert.Equal(testTree, theTree);
        }
    }
}
