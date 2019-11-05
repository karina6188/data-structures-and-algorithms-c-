using System;
using Xunit;
using StacksAndQueues;

namespace StacksAndQueuesTests
{
    public class UnitTest1
    {
        Stack stackOne = new Stack();
        Queue queueOne = new Queue();

        [Fact]
        public void PushToStack()
        {
            Assert.Equal(1, stackOne.Push(1));
        }

        [Fact]
        public void PushMultipleToStack()
        {
            stackOne.Push(1);
            stackOne.Push(2);
            stackOne.Push(3);
            Assert.Equal(4, stackOne.Push(4));
        }

        [Fact]
        public void PopFromStack()
        {
            stackOne.Push(5);
            Assert.Equal(5, stackOne.Pop());
        }

        [Fact]
        public void EmptyTheStack()
        {
            stackOne.Push(1);
            stackOne.Push(2);
            stackOne.Push(3);
            stackOne.Pop();
            stackOne.Pop();
            Assert.Equal(1, stackOne.Pop());
        }

        [Fact]
        public void PeekStack()
        {
            stackOne.Push(1);
            stackOne.Push(2);
            stackOne.Push(3);
            Assert.Equal(3, stackOne.Peek());
        }

        [Fact]
        public void InstantiateEmptyStack()
        {
            Assert.True(stackOne.isEmpty());
        }

        [Fact]
        public void EnqueueToQueue()
        {
            Assert.Equal(1, queueOne.Enqueue(1));
        }

        [Fact]
        public void EnqueueMultipleToQueue()
        {
            queueOne.Enqueue(1);
            queueOne.Enqueue(2);
            Assert.Equal(3, queueOne.Enqueue(3));
        }

        [Fact]
        public void DequeueFromQueue()
        {
            queueOne.Enqueue(8);
            Assert.Equal(8, queueOne.Dequeue());
        }

        [Fact]
        public void EmptyTheQueue()
        {
            queueOne.Enqueue(1);
            queueOne.Enqueue(2);
            queueOne.Enqueue(3);
            queueOne.Enqueue(4);
            Assert.Equal(1, queueOne.Dequeue());
        }

        [Fact]
        public void PeekQueue()
        {
            queueOne.Enqueue(1);
            queueOne.Enqueue(2);
            Assert.Equal(1, queueOne.Peek());
        }

        [Fact]
        public void InstantiateEmptyQueue()
        {
            Assert.True(queueOne.isEmpty());
        }
    }
}
