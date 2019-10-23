using LinkedLists;
using System;
using System.Collections.Generic;
using Xunit;
using static LinkedLists.Program;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void AppendToEnd()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(7);
            Assert.True(linklist.Append(7));
        }

        [Fact]
        public void AppendMutipleToEnd()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(7);
            linklist.Append(21);
            linklist.Append(9);
            linklist.Append(23);
            Assert.True(linklist.Append(23));
        }

        [Fact]
        public void InsertBeforeInMiddle()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(1);
            linklist.Append(2);
            linklist.Append(3);
            linklist.Append(4);
            linklist.Append(5);
            linklist.Append(6);
            Assert.True(linklist.InsertBefore(5, 100));
        }

        [Fact]
        public void InsertBeforeFirst()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(5);
            linklist.Append(10);
            linklist.Append(15);
            linklist.Append(20);
            Assert.True(linklist.InsertBefore(5, 100));
        }

        [Fact]
        public void InsertAfterInMiddle()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(11);
            linklist.Append(22);
            linklist.Append(33);
            linklist.Append(14);
            linklist.Append(44);
            Assert.True(linklist.InsertAfter(14, 100));
        }

        [Fact]
        public void InsertAfterLast()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(7);
            linklist.Append(21);
            linklist.Append(48);
            linklist.Append(55);
            Assert.True(linklist.InsertAfter(55, 100));
        }
    }
}
