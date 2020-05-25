using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BinaryTree
{
    public class BinaryTree<T>
    {
        public Node Root { get; set; }

        public IEnumerable<T> PreOrder(Node root)
        {
            if (root == null)
                yield break;

            yield return root.Value;

            foreach(T item in PreOrder(root.Left))
            {
                yield return item;
            }

            foreach (T item in PreOrder(root.Right))
            {
                yield return item;
            }
        }

        public class Node
        {
            public T Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node (T value)
            {
                Value = value;
            }
        }
    }
}
