using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Array
{
    public class ArrayReverse
    {
        public static int[] ReverseArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[i] = array[array.Length - (1 + i)];
            }

            return reverseArray;
        }
    }
}
