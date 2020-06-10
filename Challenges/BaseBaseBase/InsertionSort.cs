using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.BaseBaseBase
{
        public class InsertionSort
        {
            public static int[] InserstionSortMethod(int[] arr)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int j = i - 1;
                    int curr = arr[i];

                    while(j >= 0 && curr < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                        
                    }
                    arr[j + 1] = curr;
                }
                return arr;
            }
        }
}
