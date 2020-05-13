using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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

        [Fact]
        public void DoesItExist()
        {
            LinkedList list = new LinkedList();

            list.Insert(5);
            list.Insert(10);

            Assert.True(list.Include(10));
        }

        [Fact]
        public void DoesItNotExist()
        {
            LinkedList list = new LinkedList();

            list.Insert(5);
            list.Insert(10);

            Assert.False(list.Include(9));
        }

        [Fact]
        public void InsertBeforeFirstNode()
        {
            LinkedList list = new LinkedList();

            list.Insert(1);

            list.InsertBefore(1, 5);

            Assert.Equal(5, list.Head.Value);
        }



        //skip a few one-hundred
        [Fact]
        public void KFromEnd() 
        {
            LinkedList list = new LinkedList();
            list.Insert(14);
            list.Insert(44);
            list.Insert(55);
            list.Insert(1);
            list.Insert(99);


            Assert.Equal(55, list.KthFromEnd(2));
        }

        [Fact]
        public void KIsZeroWhichIsActuallyTheEnd()
        {
            LinkedList list = new LinkedList();
            list.Insert(10);



            Assert.Equal(10, list.KthFromEnd(0));
        }

        [Fact]
        public void KIsNegative()
        {
            LinkedList list = new LinkedList();
            list.Insert(14);
            list.Insert(44);
            list.Insert(55);
            list.Insert(1);
            list.Insert(99);

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                int actually = list.KthFromEnd(-40);
            });


        }

        [Fact]
        public void KIsBiggerThanTheList()
        {
            LinkedList list = new LinkedList();
            list.Insert(14);
            list.Insert(44);
            list.Insert(55);
            list.Insert(1);
            list.Insert(99);

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                int actually = list.KthFromEnd(6);
            });
        }

    }


}
