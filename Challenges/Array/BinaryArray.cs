using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Array
{
    public class BinaryArray
    {
        public static int ArrayBinary(int[] array, int insertedValue)
        {
            int low = 0;
            int high = array.Length - 1;
            int notFound = -1;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if (insertedValue == array[mid])
                {
                    return mid;
                }
                else if (insertedValue < array[mid])
                {
                    high = mid - 1;
                }
                else if (insertedValue > array[mid])
                {
                    low = mid + 1;
                }
                         
            }
            return notFound;
        }
    }
}
