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
    }


}
