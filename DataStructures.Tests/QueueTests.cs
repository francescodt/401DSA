using System;
using System.Text;
using Xunit;
using DataStructures.Queue;

namespace DataStructures.Tests.QueueTests
{
    public class QueueTests
    {
        [Fact]
        public void EnqueueAddsMoreThanOne()
        {
            Queue<int> testQueue = new Queue<int>();
            testQueue.Enqueue(1);

            int result = testQueue.Enqueue(2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void PeekSeesFrontQueue()
        {
            Queue<int> testQueue = new Queue<int>();
            testQueue.Enqueue(3);
            testQueue.Enqueue(4);

            int result = testQueue.Peek();

            Assert.Equal(3, result);
        }

        [Fact]
        public void DequeueHasValueOfFront()
        {
            Queue<int> testQueue = new Queue<int>();
            testQueue.Enqueue(10);
            testQueue.Enqueue(20);
            testQueue.Enqueue(30);

            int result = testQueue.Dequeue();

            Assert.Equal(10, result);
        }
    }
}
