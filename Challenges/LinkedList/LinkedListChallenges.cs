using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    class LinkedListChallenges
    {
        public Node MergeList(Node list1, Node list2)
        {


            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            if (list1.Value < list2.Value)
            {
                list1.Next = MergeList(list1.Next, list2);
                return list1;
            }
            else
            {
                list2.Next = MergeList(list1, list2.Next);
                return list2;
            }
        }
    }
}
