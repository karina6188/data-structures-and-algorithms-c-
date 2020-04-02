using System;
using Xunit;
using LinkedListImplementation;

namespace LinkedListImplementationTests
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiateLinkedList()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(7);
            Assert.True(linklist.Append(7));
        }

        [Fact]
        public void InsertToHead()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(10);
            linklist.Append(20);
            linklist.Append(30);
            linklist.Insert(80);
            Assert.Equal(80, linklist.Insert(80));
        }

        [Fact]
        public void InsertHeadBeforeFirst()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(10);
            linklist.Append(20);
            linklist.Append(30);
            Assert.Equal(10, linklist.InsertTest(80));
        }

        [Fact]
        public void InsertMultipleNodes()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(99);
            linklist.Append(98);
            linklist.Append(97);
            linklist.Insert(100);
            linklist.Insert(101);
            linklist.Insert(102);
            Assert.Equal(100, linklist.Insert(100));
            Assert.Equal(101, linklist.Insert(101));
            Assert.Equal(102, linklist.Insert(102));
        }

        [Fact]
        public void FindNodeValue()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(21);
            linklist.Append(22);
            linklist.Append(23);
            linklist.Append(24);
            linklist.Append(25);
            Assert.True(linklist.Includes(24));
            Assert.False(linklist.Includes(58));
        }

        [Fact]
        public void ShowAllValues()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(11);
            linklist.Append(22);
            linklist.Append(33);
            linklist.Append(44);
            linklist.Append(55);
            Assert.Equal("11 --> 22 --> 33 --> 44 --> 55", linklist.toString());

        }
    }
}
