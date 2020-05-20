using System;
using System.Text;

namespace DataStructures.Queue
{
    public class Queue<T>
    {
        private Node front;
        private Node rear;

        public T Enqueue(T value)
        {
            Node newRear = new Node(value);

            if (rear == null)
            {
                front = rear = newRear;
                return rear.Value;
            }

            rear.Next = newRear;
            rear = newRear;

            return rear.Value;
        }

        public T Dequeue()
        {
            if (front == null)
                throw new QueueEmptyException();

            Node emptySpot = front;
            front = front.Next;
            emptySpot.Next = null;

            if (front == null)
                rear = null;

            return emptySpot.Value;
        }

        public T Peek()
        {
            if (front == null)
                throw new QueueEmptyException();

            return front.Value;
        }

        public bool IsEmpty()
        {
            if (front == null)
            {
                return true;
            }
            return false;
        }

        public class Node
        {
            public Node(T value)
            {
                Value = value;
                Next = null;
            }

            public T Value { get; set; }
            public Node Next { get; set; }


        }
        
    }
}
