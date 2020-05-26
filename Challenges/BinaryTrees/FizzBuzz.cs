using DataStructures;
using DataStructures.BinaryTrees;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.BinaryTrees
{
    public class FizzBuzz
    {

        public static BinarySearchTree<string> FizzBuzzTree(BinarySearchTree<string> tree)
        {
            IEnumerable<int> treeEnumerable = tree.PreOrder;
            BinaryTree<string> treeString = new BinaryTree<string>();

            foreach (var item in treeEnumerable)
            {
                if (item % 15 == 0)
                {
                    treeString.Add("Buzz");
                }
                else if (item % 5 == 0)
                {
                    treeString.Add("Buzz");
                }
                else if (item % 3 == 0)
                {
                    treeString.Add("Fizz");
                }
                else treeString.Add(item.ToString());
            }
            return treeString;
        }
    }
}
