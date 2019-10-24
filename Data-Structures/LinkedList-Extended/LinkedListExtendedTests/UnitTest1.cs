using LinkedList_Extended;
using System;
using Xunit;
using static LinkedList_Extended.Program;

namespace LinkedListExtendedTests
{
    public class UnitTest1
    {
        [Fact]
        public void KGreaterThanLength()
        {
            LinkedList_Extend linklist = new LinkedList_Extend();
            linklist.Append(1);
            linklist.Append(2);
            linklist.Append(3);
            linklist.Append(4);
            linklist.Append(5);
            linklist.Append(6);
            linklist.ReadValueFromEnd(2);
            Assert.Equal("Not valid.", linklist.ReadValueFromEnd(8));
        }

        [Fact]
        public void KEqualsLength()
        {
            LinkedList_Extend linklist = new LinkedList_Extend();
            linklist.Append(1);
            linklist.Append(2);
            linklist.Append(3);
            linklist.Append(4);
            linklist.Append(5);
            linklist.Append(6);
            linklist.ReadValueFromEnd(2);
            Assert.Equal("1", linklist.ReadValueFromEnd(5));
        }

        [Fact]
        public void KIsNegative()
        {
            LinkedList_Extend linklist = new LinkedList_Extend();
            linklist.Append(1);
            linklist.Append(2);
            linklist.Append(3);
            linklist.Append(4);
            linklist.Append(5);
            linklist.Append(6);
            linklist.ReadValueFromEnd(2);
            Assert.Equal("Not valid.", linklist.ReadValueFromEnd(-5));
        }

        [Fact]
        public void ListSizeIs1()
        {
            LinkedList_Extend linklist = new LinkedList_Extend();
            linklist.Append(1);
            linklist.Append(2);
            linklist.Append(3);
            linklist.Append(4);
            linklist.Append(5);
            linklist.Append(6);
            linklist.ReadValueFromEnd(2);
            Assert.NotEqual("1", linklist.ReadValueFromEnd(6));
        }

        [Fact]
        public void KInMiddle()
        {
            LinkedList_Extend linklist = new LinkedList_Extend();
            linklist.Append(1);
            linklist.Append(2);
            linklist.Append(3);
            linklist.Append(4);
            linklist.Append(5);
            linklist.Append(6);
            linklist.ReadValueFromEnd(2);
            Assert.Equal("4", linklist.ReadValueFromEnd(2));
        }
    }
}
