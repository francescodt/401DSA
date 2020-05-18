using System;
using System.Text;
using Xunit;
using DataStructures.Stack;

namespace DataStructures.Tests.StackTests
{
    public class StackTests
    {
        
        [Fact]
        public void CanPushOnAStack()
        {
            Stacks<int> testStack = new Stacks<int>();

            int result = testStack.Push(5);

            Assert.Equal(5, result);
        }

    }
}
