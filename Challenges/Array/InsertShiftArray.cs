using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Array
{
     public class InsertShiftArray
    {
        public static int[] ArrayShift(int[] array, int valueToInsert)
        {
            int midPoint = (array.Length + 1) / 2;

            int[] result = new int[array.Length + 1];

            for(int i = 0; i < result.Length; i++)
            {
                if (i < midPoint)
                {
                    result[i] = array[i];
                }
                else if (i == midPoint)
                {
                    result[i] = valueToInsert;
                }
                else
                {
                    result[i] = array[i - 1];
                }
            }
            return result;
        }

    }
}
