using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BinaryTrees
{
    class NumberBinaryTree : BinaryTree<int>
    {
        public int GetMax(Node node)
        {
            if (node == null)
            {
                return int.MinValue;
            }

            var result = node.Value;
            var leftResult = GetMax(node.Left);
            var rightResult = GetMax(node.Right);

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
