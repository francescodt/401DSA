using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.BaseBaseBase
{
        public class InsertionSort
        {
            public static int[] InserstionSortMethod(int [] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int j = i - 1;
                    int temp = arr[i];

                    while(j >= 0 && temp < arr[j])
                    {
                        arr[j + i] = arr[j];
                        j = j + i;
                        arr[j + 1] = temp;
                    }
                }
                return arr;
            }
        }
}
