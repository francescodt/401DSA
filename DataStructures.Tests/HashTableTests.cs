using DataStructures.HashingTables;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class HashTableTests
    {

        [Fact]
        public void CanHash()
        {
            string key = "Cat";

            int result = HashTable.HashCode(key);

            Assert.Equal(14, result);
        }

        [Fact]
        public void WordsCanExist()
        {
            HashTable newTable = new HashTable(99);

            newTable.AddHash("dog", "cat");

            Assert.True(newTable.HashExists("dog"));
        }

        [Fact]
        public void CanAddKeyValues()
        {
            HashTable newTable = new HashTable()
        }
    }
}
