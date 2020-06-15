using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashingTables
{
    class HashTable
    {

        public Node[] Buckets { get; set; }
        public int BucketCount { get; set; }
        public HashTable(int buckets)
        {
            Buckets = new Node[buckets];
            BucketCount = buckets;
        }


        public static int HashCode(string key)
        {
            if (key is null || key == "")
                throw new ArgumentException("Cannot hash key");

            int sumofAscii = 0;

            foreach (char letter in key)
            {
                int letterValue = (int)letter;
                sumofAscii += letterValue;
            }

            int hashProduct = sumofAscii * 599;

            int hashIndex = hashProduct % 99;

            return hashIndex;
        }

        public class Node
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public Node Next { get; set; }
            public Node(string key, string value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }
    }
}
