﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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


        public IEnumerable<T> Breadth()
        {
            if (Root == null)
                yield break;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(this.Root);

            while (queue.Count > 0)
            {
                Node front = queue.Dequeue();

                yield return front.Value;

                if (front.Left != null)
                {
                    queue.Enqueue(front.Left);
                }

                if (front.Right != null)
                {
                    queue.Enqueue(front.Right);
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
