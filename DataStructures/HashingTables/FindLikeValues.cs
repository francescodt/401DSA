using DataStructures.BinaryTrees;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DataStructures.HashingTables
{
    public class FindLikeValues
    {

        public static List<int> TreeIntersection(BinarySearchTree<int> firstTree, BinarySearchTree<int> secondTree)
        {
            HashTable myTable = new HashTable(10);
            List<int> result = new List<int>();

            List<int> firstTreeValue = firstTree.PreOrder(firstTree.Root).ToList();
            List<int> secondTreeValue = secondTree.PreOrder(secondTree.Root).ToList();

            foreach(int value in firstTreeValue)
            {
                string keyOne = value.ToString();
                myTable.AddHash(keyOne, null);
            }

            foreach (int value in secondTreeValue)
            {
                string keyTwo = value.ToString();
                int currentIndex = HashTable.HashCode(keyTwo);
                HashTable.Node current = myTable.Buckets[currentIndex];

                while (current != null)
                {
                    if (current.Value == value.ToString())
                    {
                        int match = value;
                        result.Add(match);
                        break;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

            }
            return result;
        }

    }
}
