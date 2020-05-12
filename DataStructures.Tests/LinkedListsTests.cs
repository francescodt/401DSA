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
    }


}
