using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class ArrayReverse
    {
        public static int[] ReverseArray(int[] array)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int length = arr.Length - 1;
            string strReverse = null;

            while (length >= 0)
            {
                strReverse = strReverse + arr[length];
                length--;
            }

            return strReverse;
        }
    }
}
