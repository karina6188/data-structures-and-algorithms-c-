using LLMerge;
using System;
using Xunit;

namespace LLMergeTests
{
    public class UnitTest1
    {
        [Fact]
        public void NumberOfAllNodes()
        {
            LinkedList list1 = new LinkedList();
            list1.Append(1);
            list1.Append(3);
            list1.Append(5);
            list1.Append(7);
            list1.Append(9);

            LinkedList list2 = new LinkedList();
            list2.Append(2);
            list2.Append(4);
            list2.Append(6);
            list2.Append(8);
            list2.Append(10);

            EmptyClass list3 = new EmptyClass();
            list1.Head = list3.MergeLists(list1.Head, list2.Head);
            Assert.Equal(10, list1.PrintList());
        }

        [Fact]
        public void NodesAreMerged()
        {
            LinkedList list1 = new LinkedList();
            list1.Append(100);
            list1.Append(98);
            list1.Append(96);
            list1.Append(94);
            list1.Append(92);

            LinkedList list2 = new LinkedList();
            list2.Append(99);
            list2.Append(97);
            list2.Append(95);
            list2.Append(93);
            list2.Append(91);
            list2.Append(89);
            list2.Append(87);
            list2.Append(85);
            list2.Append(83);

            EmptyClass list3 = new EmptyClass();
            list1.Head = list3.MergeLists(list1.Head, list2.Head);
            Assert.Equal(100, list1.Head.Data);
            Assert.Equal(99, list1.Head.Next.Data);
            Assert.Equal(98, list1.Head.Next.Next.Data);
            Assert.Equal(97, list1.Head.Next.Next.Next.Data);
            Assert.Equal(96, list1.Head.Next.Next.Next.Next.Data);
            Assert.Equal(95, list1.Head.Next.Next.Next.Next.Next.Data);
        }

        [Fact]
        public void AppendToEnd()
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(7);
            Assert.True(linklist.Append(7));
        }
    }
}
