using QueueWithStacks;
using System;
using System.Collections;
using Xunit;

namespace QueueWithStacksTests
{
    public class UnitTest1
    {
        PseudoQuene queue = new PseudoQuene();
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();

        [Fact]
        public void EnqueueValue()
        {
            Assert.Equal("5 4 3 2 1 22 ", queue.enqueue(22));
        }

        [Fact]
        public void DequeueValue()
        {
            Assert.Equal("4 3 2 1 ", queue.dequeue());
        }

        [Fact]
        public void EnqueueValueEmpty()
        {
            Assert.Equal("8 ", queue.enqueue1(8));
        }
    }
}
