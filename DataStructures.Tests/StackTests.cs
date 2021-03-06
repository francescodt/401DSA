﻿using System;
using System.Text;
using Xunit;
using DataStructures.Stack;
using System.Net.NetworkInformation;

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

        [Fact]
        public void CanPeekAStack()
        {
            Stacks<int> testStack = new Stacks<int>();
            testStack.Push(3);
            testStack.Push(4);

            int result = testStack.Peek();

            Assert.Equal(4, result);
        }

        [Fact]
        public void CanPopAStack()
        {
            Stacks<int> testStack = new Stacks<int>();
            testStack.Push(3);
            testStack.Push(4);

            int result = testStack.Peek();

            Assert.Equal(4, result);
        }

        [Fact]
        public void PeekHasException()
        {
            Stacks<int> testStack = new Stacks<int>();

            Assert.Throws<StackEmptyException>(() =>
            {
                testStack.Peek();
            });
        }

        [Fact]
        public void IsEmptyReturnsFalseWhenNotEmpty()
        {
            Stacks<int> testStack = new Stacks<int>();
            testStack.Push(4);

            bool result = testStack.IsEmpty();

            Assert.False(result);

        }

    }
}
