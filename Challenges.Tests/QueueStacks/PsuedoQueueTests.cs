using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Tests.QueueStacks
{
    public class PsuedoQueueTests
    {

        [Fact]
        public void InstantiateEmptyQueue()
        {
            Queue<int> newQueue = new Queue<int>();
            Assert.Empty(newQueue);
        }

        [Fact]
        public void DequeuingWorks()
        {
            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(1);


            Assert.Equal(1, newQueue.Dequeue());
        }

        [Fact]
        public void EnqueuingWorks()
        {
            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(1);
            newQueue.Enqueue(3);
            newQueue.Enqueue(5);

            Assert.Contains(3, newQueue);
        }

        [Fact]
        public void DequeuingEmptyHasException()
        {
            Queue<int> newQueue = new Queue<int>();

            Assert.Throws<InvalidOperationException>(() =>
            {
                newQueue.Dequeue();
            });
        }

        [Fact]
        public void CanPeek()
        {
            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(1);
            newQueue.Enqueue(3);
            newQueue.Enqueue(5);

            Assert.Equal(1, newQueue.Peek());
        }


    }
}
