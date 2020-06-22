using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashingTables
{
    public class HashTable 
    {

        public Node[] Buckets { get; set; }
        public int BucketCount { get; set; }
        public HashTable(int buckets)
        {
            Buckets = new Node[buckets];
            BucketCount = buckets;
        }


        public void AddHash(string key, string value)
        {
            int hashTableLocation = HashCode(key);

            if (Buckets[hashTableLocation] == null)
            {
                Node newNode = new Node(key, value);
                Buckets[hashTableLocation] = newNode;
            }
            else
            {
                Node newNode = new Node(key, value);
                Node current = Buckets[hashTableLocation];

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public string GetFromTable(string key)
        {
            int index = HashCode(key);

            if (Buckets[index] == null)
            {
                return null;
            }
            else
            {
                Node current = Buckets[index];

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        return current.Value;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                return null;
            }
        }

        public bool HashExists(string key)
        {
            int index = HashCode(key);

            if (Buckets[index] == null)
            {
                return false;
            }
            else
            {
                Node current = Buckets[index];
                while (current != null)
                {
                    if (current.Key == key)
                    {
                        return true;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                return false;

            }
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
