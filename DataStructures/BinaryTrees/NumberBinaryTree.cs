using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BinaryTrees
{
    public class NumberBinaryTree : BinarySearchTree<int>
    {
        public int GetMax()
        {
            return GetMax(this.Root);
        }

        private int GetMax(Node current)
        {
            if (current == null)
            {
                return int.MinValue;
            }

            var result = current.Value;
            var leftResult = GetMax(current.Left);
            var rightResult = GetMax(current.Right);

            if (leftResult > result)
            {
                result = leftResult;
            }
            if (rightResult > result)
            {
                result = rightResult;
            }
            return result;
        }
    }
}
