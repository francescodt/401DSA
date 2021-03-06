﻿using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace DataStructures
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public override string ToString()
        {
            if (Head == null)
            {
                return "";

            }
            else
            {
                Node current = Head;
                string list = "";

                while (current != null)
                {
                    list += "{ ";
                    list += current.ToString();
                    current = current.Next;
                    if (current != null)
                    {
                        list += " } -> ";
                    }
                }

                list += " } -> Null";

                return list;
            }
        }

        public void Insert(int value)
        {

            if(Head == null)
            {
                Head = new Node(value);
            }
            else
            {
                Node node = new Node(value);
                node.Next = Head;
                Head = node;
            }
        }

        public bool Include(int value)
        {
            if(Head != null)
            {
                Node current = Head;

                while (current != null)
                {
                    if (current.Value == value)
                    {
                        return true;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }


            
        }

        public void InsertBefore(int value, int newValue)
        {
            if (Head.Value == value)
            {
                Insert(newValue);
                return;
            }

            Node newNode = new Node(newValue);

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
        }

        public void InsertAfter(int value, int newValue)
        {
            Node newNode = new Node(newValue);

            Node current = Head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
        }

        public int KthFromEnd(int index)
        {
            int len = 0;
            int k = 0;
            Node current = Head;
            while (current != null)
            {
                current = current.Next;
                len++;
            }

            int idx = len - 1;
            current = Head;

            if (index > idx || index < 0)
            {
                throw new IndexOutOfRangeException("Try choosing a number that actually matters.");
            }

            for (int i = idx; i > index; i--)
            {
                current = current.Next;
            }

            k = current.Value;
            return k;
        }

    }

    

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
