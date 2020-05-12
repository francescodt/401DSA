using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructures.Tests
{
    public class LinkedListsTests
    {
        [Fact]
        public void EmptyListInstantiate()
        {
            LinkedList list = new LinkedList();

            Assert.Equal("", list.ToString());

        }

        [Fact]
        public void CreateEmptyList()
        {
            //Arrange


            // Act
            LinkedList testList = new LinkedList();

            //Assert
            Assert.NotNull(testList);
        }

        [Fact]
        public void LinkedListInsert()
        {
            LinkedList insertToLinkedList = new LinkedList();

            insertToLinkedList.Insert(12);

            Assert.Equal(12, insertToLinkedList.Head.Value);

        }

        [Fact]
        public void InsertOneNode()
        {
            LinkedList list = new LinkedList();

            list.Insert(12);

            Assert.Equal("{ 12 } -> Null", list.ToString());
        }

        [Fact]
        public void InsertMultipleNodes()
        {
            LinkedList list = new LinkedList();

            list.Insert(5);
            list.Insert(10);

            Assert.Equal("{ 10 } -> { 5 } -> Null", list.ToString());
        }
    }


}
