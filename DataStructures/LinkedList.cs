using System;

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

        public bool Includes(int value)
        {
            if(Head == null)
            {
                Node current = Head;

                while (current != null)
                {
                    if (current.Data == value)
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
    }

    public void InsertBefore(int value, int newValue)
    {
        if (Head.Value == value)
        {
            Include(newValue);
            return;
        }

        Node newNode = new Node(newValue);

        Node current = Head;
        while (current != null)
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

    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public override string ToString()
        {
            return Data.ToString();
        }
        public Node(int value)
        {
            Data = value;
            Next = null;
        }
    }
}
