using System;
using System.Collections;
using System.Text;

namespace DataStructures.Stack
{
    public class Stacks<T>
    {

        private Node top;

        public T Push(T value)
        {
            Node newTop = new Node(value);

            newTop.Next = top;
            top = newTop;

            return top.Value;
        }

        public T Pop(T value)
        {
            if (top == null)
            {
                throw new StackEmptyException();

            }

            Node emptySpot = top;

            if (top.Next == null)
            {
                top = null;
                emptySpot.Next = null;

                return emptySpot.Value;
            }

            top = top.Next;
            emptySpot.Next = null;

            return emptySpot.Value;
        }

        public T Peek()
        {
            if (top == null)
                throw new StackEmptyException();

            return top.Value;
        }

        public bool IsEmpty()
        {
            if (top == null)
            {
                return true;
            }

            return false;
        }
        
        

        private class Node
        {
            public Node(T value) { Value = value; }
            public Node Next { get; set; }
            public T Value { get; }
        }
    }
}
