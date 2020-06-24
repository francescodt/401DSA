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

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ArguementException(string key)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var result = HashTable.HashCode(key);
            });
        }

        [Fact]
        public void CanReturnNull()
        {
            HashTable newTable = new HashTable(100);
            string newKey = "dog";
            string newValue = "wally";

            newTable.AddHash(newKey, newValue);

            string result = newTable.GetFromTable("Ian");

            Assert.Null(result);
        }
    }
}
