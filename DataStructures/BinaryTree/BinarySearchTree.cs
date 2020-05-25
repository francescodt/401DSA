using System;
using System.Text;

namespace DataStructures.BinaryTree
{
    public class BinarySearchTree<T> : BinaryTree<T>
        where T : IComparable<T>
    {

        public void Add(T value)
        {

            Node newNode = new Node(value);
            Node current = Root;
            Node parent = null;

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                while (current != null)
                {
                    parent = current;
                    if (value.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }

                if (value.CompareTo(parent.Value) < 0)
                {
                    parent.Left = newNode;
                }
                else
                {
                    parent.Right = newNode;
                }

                
            }
        }
    }
}
