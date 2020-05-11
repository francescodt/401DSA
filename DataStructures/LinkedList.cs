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


    }
}
