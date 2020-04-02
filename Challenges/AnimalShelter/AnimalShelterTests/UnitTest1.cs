using System;
using System.Collections;
using Xunit;
using AnimalShelter;
using Queue = AnimalShelter.Queue;

namespace AnimalShelterTests
{
    public class UnitTest1
    {
        Queue queue = new Queue();
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();

        [Fact]
        public void EnqueueCat()
        {
            stack1.Push("dog");
            stack1.Push("dog");
            stack1.Push("dog");
            stack1.Push("dog");
            Assert.Equal("cat ", queue.enqueue("cat"));
        }

        [Fact]
        public void EnqueueNotDogOrCat()
        {
            stack1.Push("dog");
            stack1.Push("dog");
            stack1.Push("dog");
            stack1.Push("dog");
            Assert.Equal("The shelter only takes dogs or cats.", queue.enqueue("snake"));
        }

        [Fact]
        public void DequeueAnimalNotInStack()
        {
            stack1.Push("dog");
            stack1.Push("dog");
            stack1.Push("dog");
            stack1.Push("dog");
            Assert.Equal("null", queue.dequeue("racoon"));
        }
    }
}
