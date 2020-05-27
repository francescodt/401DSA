using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BinaryTrees
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

        public IEnumerable<T> InOrder(Node current)
        {
            if (current is null)
                yield break;

            foreach (T item in InOrder(current.Left))
            {
                yield return item;
            }

            yield return current.Value;

            foreach (T item in InOrder(current.Right))
            {
                yield return item;
            }
        }

        public IEnumerable<T> PostOrder(Node current)
        {
            if (current is null)
                yield break;

            foreach (T item in PostOrder(current.Left))
            {
                yield return item;
            }

            foreach (T item in PostOrder(current.Right))
            {
                yield return item;
            }

            yield return current.Value;
        }

        public List<T> Breadth()
        {
            List<T> result = new List<T>();
            Queue<Node> treeQueue = new Queue<Node>();
            Node current = Root;
            treeQueue.Enqueue(current);
            Breadth(treeQueue, result, current);

            return result;
        }

        public void Breadth(Queue<Node> treeQueue, List<T> result, Node current)
        {
            while (treeQueue.Peek() != null)
            {
                Node first = treeQueue.Dequeue();
                result.Add(first.Value);

                if (first.Left != null)
                {
                    treeQueue.Enqueue(first.Left);
                }

                if (first.Right != null)
                {
                    treeQueue.Enqueue(first.Right);
                }

            }

        }


        public class Node
        {
            public T Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node (T value)
            {
                this.Value = value;
                
            }
        }
    }
}
