﻿using System;
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
            return value;
        }

        public T Peek()
        {
            return default;
        }

        public bool IsEmpty()
        {
            return default;
        }
        
        

        private class Node
        {
            public Node(T value) { Value = value; }
            public Node Next { get; set; }
            public T Value { get; }
        }
    }
}
